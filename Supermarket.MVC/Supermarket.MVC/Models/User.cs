using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.MVC.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Reviews = new HashSet<Review>();
        }

        public ICollection<Review> Reviews { get; set; }
    }
}
