using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public string Mypage()
        //{
        //    return "hii";
        //}
        public ActionResult Mypage()
        {
            return Content("hii mvc");
        }
        public ViewResult MyPage2()
        {
            return View();
        }
    }
}