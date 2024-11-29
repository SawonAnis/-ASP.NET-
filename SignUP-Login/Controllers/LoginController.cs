using Signup_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Signup_Login.Controllers
{
    public class LoginController : Controller
    {
        SignupLoginEntities db=new SignupLoginEntities();   
        // GET: Login
        public ActionResult Index()
        {
            return View();
        } 
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User u)
        {
            if (ModelState.IsValid==true)
            {
                db.Users.Add(u);    
             int a=   db.SaveChanges();
                if (a > 0) {
                    ViewBag.InsertMessage = "Registered";
                    ModelState.Clear();

                }
                else
                {
                    ViewBag.InsertMessage = "Failed";
                }
            }
            return View();
        }
    }
}