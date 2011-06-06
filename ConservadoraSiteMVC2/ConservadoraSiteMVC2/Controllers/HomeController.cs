using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ConservadoraSiteMVC2.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            Models.conservadoraEntities modelo = new Models.conservadoraEntities();
            
            return View();
        }
    }
}
