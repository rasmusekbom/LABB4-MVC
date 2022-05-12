using Bokhandel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4_MVC.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
        }
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBooks> CustomerBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //SEEDING DATA TO DB

            modelBuilder.Entity<Book>().HasData(new List<Book>()
            {
                new Book() { BookId = 1, Title = "In i labyrinten", Author = "Sigge Eklund", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://media.bonnierforlagen.se/bokbilder/tif/9789100127473.jpg?timestamp=20160307042105" },
                new Book() { BookId = 2, Title = "The Survivors", Author = "Alexander Schulman", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://media.bonnierforlagen.se/bokbilder/tif/9789100182496.jpg?timestamp=20200511074633" },
                new Book() { BookId = 3, Title = "Harry Potter & The Prisoner From Azkaban", Author = "J.K Rowling", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://cdna.artstation.com/p/assets/images/images/010/777/898/large/alan-vilalte-prisonerofazkaban.jpg?1526182197" },
                new Book() { BookId = 4, Title = "The Da Vinci Code", Author = "Dan Brown", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://donateanybook.com/wp-content/uploads/2020/06/the-da-vinci-code-589f9cee3df78c4758a2d9e7.jpg" },
                new Book() { BookId = 5, Title = "Angels and Demons", Author = "Dan Brown", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://d3525k1ryd2155.cloudfront.net/h/525/436/535436525.0.m.jpg" },
                new Book() { BookId = 6, Title = "Life of Pi", Author = "Yann Martel", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://kbimages1-a.akamaihd.net/d33e35b8-5e64-42ce-a67e-102f934788d7/1200/1200/False/life-of-pi.jpg" },
                new Book() { BookId = 7, Title = "Birdsong", Author = "Sebastian Faulks", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In feugiat at purus sit amet lobortis. Ut convallis turpis arcu, ut bibendum turpis auctor eu. Ut id posuere tortor, a iaculis sem.", BookUrl = "https://images-na.ssl-images-amazon.com/images/I/71nV-ZcSeAL.jpg" },
            });

            modelBuilder.Entity<Customer>().HasData(new List<Customer>()
            {
                new Customer() { CustomerId = 1, Name = "Rasmus Ekbom", Address = "Olnirsvägen 50B", Email = "rasmusekbom97@gmail.com", PhoneNr = 768016461 },
                new Customer() { CustomerId = 2, Name = "Anitra Ngoensuwan", Address = "Olnirsvägen 50A", Email = "anitrangoen@gmail.com", PhoneNr = 768142421 },
                new Customer() { CustomerId = 3, Name = "Fredrik Olsson", Address = "Freddegatan 1B", Email = "fredrikolsson@gmail.com", PhoneNr = 761535155 },
                new Customer() { CustomerId = 4, Name = "Kim Tikkanen", Address = "Kimgatan 13A", Email = "kimtikkanen@gmail.com", PhoneNr = 767257257 },

                new Customer() { CustomerId = 5, Name = "Fredrik Svedin", Address = "Sveddegatan 36B", Email = "fredrikdsvedin@gmail.com", PhoneNr = 761351355 },
                new Customer() { CustomerId = 6, Name = "Daniel Ekbom", Address = "Backböjen 4", Email = "danielekbom@gmail.com", PhoneNr = 767646737 },
                new Customer() { CustomerId = 7, Name = "An Groth", Address = "Grothgatan 3B", Email = "angroth@gmail.com", PhoneNr = 768368388 },
                new Customer() { CustomerId = 8, Name = "Albin Andersson", Address = "Umeågatan 74A", Email = "albinandersson@gmail.com", PhoneNr = 761351355 },
            });

            modelBuilder.Entity<CustomerBooks>().HasData(new List<CustomerBooks>()
            {
                new CustomerBooks() { CustomerBookId = 1, BookId = 1, CustomerId = 1, StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(+20), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 2, BookId = 2, CustomerId = 2, StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(+22), IsReturned = true},
                new CustomerBooks() { CustomerBookId = 3, BookId = 3, CustomerId = 3, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(+5), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 4, BookId = 4, CustomerId = 4, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(+26), IsReturned = true},
                new CustomerBooks() { CustomerBookId = 5, BookId = 5, CustomerId = 5, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(+21), IsReturned = true},
                new CustomerBooks() { CustomerBookId = 6, BookId = 6, CustomerId = 6, StartDate = DateTime.Now.AddDays(-15), EndDate = DateTime.Now.AddDays(+13), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 7, BookId = 7, CustomerId = 7, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(+14), IsReturned = true},
                new CustomerBooks() { CustomerBookId = 8, BookId = 3, CustomerId = 8, StartDate = DateTime.Now.AddDays(-6), EndDate = DateTime.Now.AddDays(+16), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 9, BookId = 2, CustomerId = 1, StartDate = DateTime.Now.AddDays(-13), EndDate = DateTime.Now.AddDays(+17), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 10, BookId = 3, CustomerId = 2, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(+19), IsReturned = false},
                new CustomerBooks() { CustomerBookId = 11, BookId = 4, CustomerId = 3, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(+16), IsReturned = true},
                new CustomerBooks() { CustomerBookId = 12, BookId = 5, CustomerId = 4, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(+13), IsReturned = false},
            });
        }
    }
}
