using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace RugbyAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hey, " + name;
            ViewData["ID"] = ID;

            return View();
        }

    }
}
