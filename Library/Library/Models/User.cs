using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int? Age { get; set; }
        public byte? Gender { get; set; }
        public virtual ICollection<BookRent> BookRents { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
