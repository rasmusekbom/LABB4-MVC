using Bokhandel.Models;
using Labb4_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Controllers
{
    public class CustomerBooksController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;
        public CustomerBooksController(ICustomerRepository custRepo, IBookRepository bookRepo, LibraryDbContext context)
        {
            _context = context;
            _customerRepository = custRepo;
            _bookRepository = bookRepo;
        }

        //GET - Show all books. -> book/list
        public async Task<IActionResult> List()
        {
            return View(await _context.CustomerBooks.ToListAsync());
        }
    }
}
