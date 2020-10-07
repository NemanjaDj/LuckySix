using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int? Age { get; set; }
        public virtual ICollection<BookRent> BookRents { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
