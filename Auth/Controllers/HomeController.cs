using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorization.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }  
        public ActionResult About()
        {
            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            return View();
        }
    }
}