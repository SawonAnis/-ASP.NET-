using DbFirstApproachEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirstApproachEF.Controllers
{
    public class HomeController : Controller
    {


        DatabaseFirstEFEntities db = new DatabaseFirstEFEntities(); 
      public ActionResult Index()
        {
            var data=db.students.ToList();  

            return View(data);  
        }
        public ActionResult Create()
        {
        

            return View();  
        }
        [HttpPost]
        public ActionResult Create(student s)
        {

            if (ModelState.IsValid == true)
            {
                db.students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "Data Inserted";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "Data not Inserted";

                }
            }
            return View();  
        }

    }
}