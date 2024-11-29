using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorization.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(Table_1 u,string ReturnUrl)
        {
            return View();
        }

    }
}