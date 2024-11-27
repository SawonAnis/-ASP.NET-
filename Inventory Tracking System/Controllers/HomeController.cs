using System.Web.Mvc;

namespace InventoryTrackingSystem.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult AdminDashboard()
        {
         
            if (Session["Role"]?.ToString() != "Admin")
            {
                return RedirectToAction("Index", "Home"); 
            }

            return View();
        }

        public ActionResult UserDashboard()
        {
         
            if (Session["Role"]?.ToString() != "Staff")
            {
                return RedirectToAction("Index", "Home"); 
            }

            return View();
        }


    }
}
