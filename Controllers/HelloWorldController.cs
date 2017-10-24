using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        //
        // GET: /HelloWorld/Welcome/

        public ActionResult Welcome(string name, int num = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = num;

            return View();
            //return "This is the Welcome action method..." + name + " - " + num;
        }

        public ActionResult Basic1()
        {
            return View();
        }

        public ActionResult Basic2()
        {
            return View();
        }

    }
}
