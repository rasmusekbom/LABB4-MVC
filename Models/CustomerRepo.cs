using Labb4_MVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public class CustomerRepo : ICustomerRepository
    {
        private LibraryDbContext _context;
        public CustomerRepo(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetSingleCustomer(int customer)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == customer);
        }
    }
}
