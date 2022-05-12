using Labb4_MVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public class CustomerBookRepo : ICustomerBookRepo
    {
        private LibraryDbContext _context;
        public CustomerBookRepo(LibraryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerBooks>> GetAll()
        {
            return await _context.CustomerBooks.Include(cb => cb.Book).Include(cb => cb.Customer).ToListAsync();
        }
    }
}
