using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthenticationDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationDemo.Controllers
{

    public class CookieSessionController : Controller
    {
        public readonly UserAccountContext _context;
        public CookieSessionController(UserAccountContext context)
        {
            this._context = context;
        }


        // GET: CookieSession
       // [Route ("")]
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount user)
        {
            try
            {
                _context.Add(user);
                _context.SaveChanges();
                ViewBag.message = user.Name + "has got successfull";
                return View();
            }
            catch(Exception e)
            {
                ViewBag.message = user.Name + "failed";
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserAccount user)
        {
            var log = _context.UserAccounts.Where(e => (e.Name == user.Name) && e.Password ==e.Password).ToList();
            if (log.Count == 0)
            {
                ViewBag.message = "not valid";
                return View();
            }

            else
            {
                HttpContext.Session.SetString("uname",user.Name);
                HttpContext.Session.SetString("lastlogin", DateTime.Now.ToString());
                return RedirectToAction("Createdashboard");
            }
        }
        public ActionResult Createdashboard()
        {
            if (HttpContext.Session.GetString("uname") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("uname").ToString();
                if(Request.Cookies["lastlogin"]!=null)
                ViewBag.lldt = HttpContext.Session.GetString("lastlogin").ToString();
            }
            return View();
        }
        // GET: CookieSession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Logout()
        {
            Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}