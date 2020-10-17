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

        public IActionResult Adder()
        {
            return View();
        }

        public IActionResult Arman()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.User = _db.Users.ToList();
            mymodel.Item = _db.Items.ToList();
            return View(mymodel);
        }

        public IActionResult Bake()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new ExpandoObject();
            mymodel.User = _db.Users.ToList();
            mymodel.Item = _db.Items.ToList();
            return View(mymodel);
        }

        [HttpPost]
        public IActionResult Adder(Item item)

        {
            _db.Items.Add(item);
            _db.SaveChanges();

            return RedirectToAction("Arman");
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
