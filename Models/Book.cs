using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Author { get; set; }
        public string Description { get; set; }
        
        public string BookUrl { get; set; }

        //Relationships
        public ICollection<CustomerBooks> CustomerBooks { get; set; }
    }
}
