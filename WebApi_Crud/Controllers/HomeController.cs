using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_Crud.Models;

namespace WebApi_Crud.Controllers
{
    public class HomeController : Controller
    {
        web_api_crud_dbEntities db = new web_api_crud_dbEntities();
        public ActionResult Index()
        {
         
            var employees = db.Employees.ToList(); 
            return View(employees);
        }



    }
}
