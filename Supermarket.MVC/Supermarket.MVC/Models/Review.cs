using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.MVC.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
