using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsonMVC.Models;
using HandsonMVC.Controllers;
using HandsonMVC.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsonMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { "","india", "usa", "aus" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details");
            }
            else
                return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Uname, string Password)
        {

            UserRepository rep = new UserRepository();
            User user = rep.Validate(Uname, Password);
            if (user != null)
            {
                return RedirectToAction("Details");
            }
            else
            {
                ViewData["err"] = "invalid";
                return View();
            }

        }
        public IActionResult Details([Bind(include:"Name")] User item)
        {
            return View(item);
        }
    }
}