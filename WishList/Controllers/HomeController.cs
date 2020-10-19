using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server;
using Microsoft.Extensions.Logging;
using WishList.Models;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WishListContext _db;

        public HomeController(ILogger<HomeController> logger, WishListContext wishListContext)
        {
            _logger = logger;
            _db = wishListContext;
        }

        public IActionResult Index()
        {
            return View(_db.Users.ToList());
        }

        public IActionResult AdderArman()
        {
            return View();
        }
        public IActionResult AdderBake()
        {
            return View();
        }
        public IActionResult AdderDake()
        {
            return View();
        }

        public IActionResult Arman()
        {
            return View(_db.Items.ToList());
        }

        public IActionResult Bake()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.User = _db.Users.ToList();
            mymodel.Item = _db.Items.ToList();
            return View(mymodel);
        }
        public IActionResult Dake()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.User = _db.Users.ToList();
            mymodel.Item = _db.Items.ToList();
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult AdderArman(Item item)

        {
            var newItem = new Item
            {
                UserId = 0,
                ItemName = item.ItemName
            };
            _db.Items.Add(newItem);
            _db.SaveChanges();

            return RedirectToAction("Arman");
        }

        [HttpPost]
        public IActionResult AdderBake(Item item)

        {
            var newItem = new Item
            {
                UserId = 1,
                ItemName = item.ItemName
            };
            _db.Items.Add(newItem);
            _db.SaveChanges();

            return RedirectToAction("Bake");
        }

        [HttpPost]
        public IActionResult AdderDake(Item item)

        {
            var newItem = new Item
            {
                UserId = 2,
                ItemName = item.ItemName
            };
            _db.Items.Add(newItem);
            _db.SaveChanges();

            return RedirectToAction("Dake");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
