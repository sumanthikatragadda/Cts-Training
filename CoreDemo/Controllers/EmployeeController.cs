using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;


namespace CoreDemo.Models
{
    public class EmployeeController : Controller
    {
        //Interface empr = new EmployeeRepository();
        private readonly Interface empr;
        public EmployeeController(Interface emp)
        {
            empr = emp;
        }
        //public IActionResult Search(int? id)
        //{
        //    Employee emp = empr.GetEmploy(ID);
        //    if (emp != null)
        //    {
        //        return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.dept);
        //    }
        //    else
        //        return Content("does not exist");
        //}
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee emp = empr.GetEmploy(ID);
            ////if (emp != null)
            ////{
            ////    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.dept);
            ////}
            ////else
            ////    return Content("does not exist");

            //ViewData["id"] = emp.Id;
            //ViewData["Name"] = emp.Name;
            //ViewData["Email"] = emp.Email;
            //ViewData["dept"] = emp.dept;
            //ViewBag.id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.Email = emp.Email;
            //ViewBag.dept = emp.dept;
            ViewData["Employ"] = emp;
            return View();
        }

        public IActionResult Index()
        {
            List<Employee> elist = empr.display();
            return View(elist);
        }
        public ViewResult AboutEmployee()
        {
            Employee emp = empr.GetEmploy(2);
            // ViewBag.projname = "books";
            EmployeeProjViewModel ep = new EmployeeProjViewModel();
            ep.employee = emp;
            ep.projname = "books";
            return View(ep);
        }
        public IActionResult Getallemployees()
        {
            List<Employee> elist = empr.display().Where(e => e.dept == Dept.Insurance).ToList();
            // return View("Views/Employee/Index.cshtml", elist);
            return View("Index", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Employee emp = empr.GetEmploy(2);
            // return View(emp);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                empr.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            else
                return View("Fail");
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = empr.display();
            return View(elist);
        }
        //public IActionResult Register()
        //{

        //    return View();
        //}
        public IActionResult Register(Employee employee)
        {
            bool res = empr.AddEmployee(employee);
            return RedirectToAction("Index");
        }
        //public JsonResult AboutUs()
        //{
        //    return JsonResult("{(id:1;name:")
        //}
        public bool Isexist(string email)
        {
            var res = (empr.display()).Find(r => r.Email == email);
            if (res == null)
                return true;
            else
                return false;
        }
        [AcceptVerbs("Get", "Post")]

        public JsonResult IsEmailExist(string email)
        {
            return Isexist(email) ? Json(true) : Json("email exist");
        }
        public IActionResult myPartial()
        {
            return View();
        }
    }
}
