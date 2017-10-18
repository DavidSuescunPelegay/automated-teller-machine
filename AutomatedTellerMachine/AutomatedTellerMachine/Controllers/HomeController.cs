using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Microsoft.AspNet.Identity;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        //[MyLoggingFilter]
        public ActionResult Index()
        {
            //throw new StackOverflowException();
            //var userId = User.Identity.GetUserId();
            return View();
        }

        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // GET /home/contact
        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Having trouble? Send us a message.";

            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Contact(string message)
        {
            //TODO: Send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message!";

            return View();
        }

        // GET /home/foo
        public ActionResult Foo()
        {
            return View("About");// It'll render About View, Foo it's just an aliases.
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return new HttpStatusCodeResult(403);
            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}