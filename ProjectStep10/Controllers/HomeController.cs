using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectStep10.Models;

// This is just an example statement to show how to use Git.
namespace ProjectStep10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Account a)
        {
            if (ModelState.IsValid)
            {
                if (a.password == a.confirmPassword)
                {
                    return View("UserHome", a);
                    // return RedirectToAction("UserHome", a); // Requires making a method for the View.
                }
                else
                {
                    return View(a);
                }
            }
            else
            {
                return View(a);
            }
        }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }


        [HttpGet]
        public IActionResult EditAccount()
        {
            // Go to database with id and get account with that id.
            // This is a mock up DB.

            Account a = new Account();
            a.userId = 1;
            a.name = "Patrick Toppin";
            a.email = "patrick.toppin@gmail.com";
            a.phone = "9158016325";
            a.streetAddress = "516 Fieldstone Dr.";
            a.city = "Gatesville";
            return View(a);
        }

        [HttpPost]
        public IActionResult EditAccount(Account a)
        {
            if (ModelState.IsValid)
            {
                return View("UserHome", a);
            }
            else
            {
                return View(a);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
