using Labb4_MVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public class BookRepo : IBookRepository
    {
        private LibraryDbContext _context;
        public BookRepo(LibraryDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public Customer GetSingleCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
