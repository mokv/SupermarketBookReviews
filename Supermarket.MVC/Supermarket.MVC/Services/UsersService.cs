using Microsoft.AspNetCore.Identity;
using Supermarket.MVC.Data;
using Supermarket.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.MVC.Services
{
    public class UsersService : IUsersService
    {
        private ApplicationDbContext dbContext;

        public UsersService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return dbContext.Users.ToList();
        }
    }
}
