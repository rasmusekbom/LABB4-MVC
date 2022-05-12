using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bokhandel.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Address { get; set; }
        public int PhoneNr { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Email { get; set; }

        //Relationships
        public ICollection<CustomerBooks> CustomerBooks { get; set; }
    }
}
