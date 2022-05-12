using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
