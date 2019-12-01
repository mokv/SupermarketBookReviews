using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Supermarket.MVC.Helpers;
using Supermarket.MVC.Services;

namespace Supermarket.MVC.Controllers
{
    [Authorize(GlobalConstants.AdminPolicy)]
    public class UserController : Controller
    {
        IUsersService userManager;

        public UserController(IUsersService userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = userManager.GetAllUsers();
            return View(users);
        }
    }
}