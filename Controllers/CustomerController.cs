using Bokhandel.Models;
using Bokhandel.ViewModels;
using Labb4_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Controllers
{
    public class CustomerController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerBookRepo _customerbookRepository;
        public CustomerController(ICustomerRepository custRepo, IBookRepository bookRepo, ICustomerBookRepo custbookRepo, LibraryDbContext context)
        {
            _context = context;
            _customerRepository = custRepo;
            _bookRepository = bookRepo;
            _customerbookRepository = custbookRepo;
        }

        //GET - Show all customers. -> customer/list
        public async Task<IActionResult> List()
        {
            return View(await _context.Customers.ToListAsync());
        }

        //GET - Delete customer by Id. -> customer/delete/{id}
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST - Finish the deletion. -> customer/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        // GET - Create a new Customer. -> Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST - Finish create a new Customer to DB
        [HttpPost]
        public async Task<IActionResult> Create([Bind("CustomerId,Name,Address,PhoneNr,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(customer);
        }

        // GET - Get the customer you want to edit. -> Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST - Post the changes to DB. -> Customers/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Name,Address,PhoneNr,Email")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(customer);
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }
        
        // GET THE INFORMATION ABOUT THE CUSTOMER AND PRINT OUT THE CURRENT LOANED BOOKS.
        public async Task<IActionResult> Information(int? id)
        {
            var customer = await _customerRepository.GetSingleCustomer(id ?? 1);
            if (customer != null)
            {
                var customerBooksViewModel = new CustomerViewModel();
                customerBooksViewModel.Customer = customer;
                var customerBooks = await _customerbookRepository.GetAll();

                customerBooksViewModel.Books = customerBooks.Where(cb => cb.CustomerId == customer.CustomerId)
                    .Join(await _bookRepository.GetAllBooks(),
                    o => o.BookId, i => i.BookId,
                    (cb, book) => new Book { BookId = book.BookId, Title = book.Title, Description = book.Description, Author = book.Author })
                    .ToList();
                return View(customerBooksViewModel);
            }
            Response.StatusCode = 404;
            return View("List");
        }
    }
}
