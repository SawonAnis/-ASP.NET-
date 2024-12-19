using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using LoginForm.Models;
using LoginFormMvc.Models;

namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user s)
        {
            if (ModelState.IsValid == true)
            { var data = db.users.Where(model => model.username == s.username && model.password == s.password).FirstOrDefault();
                if (data == null)
                {
                    ViewBag.ErrorMessage = "Login Failed";
                    return View();
                }
                else
                {
                    Session["username"] = s.username;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();  
            return RedirectToAction("Index","Login");
        }
        public ActionResult Reset()
        {
            ModelState.Clear(); 
            return RedirectToAction("Index","Login");
        }
    }
}