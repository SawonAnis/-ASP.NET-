using System.Linq;
using System.Web.Mvc;
using _22_46466_1.Models;


namespace InventoryTrackingSystem.Controllers
{
    public class AccountController : Controller
    {
        private InventoryDBEntities db = new InventoryDBEntities();

    
        public ActionResult Register()
        {
            return View();
        }

    
        [HttpPost]
        public ActionResult Register(string name, string email, string password, string role)
        {
            if (ModelState.IsValid)
            {
           
                var existingUser = db.Users.FirstOrDefault(u => u.Email == email);
                if (existingUser != null)
                {
                    ViewBag.Message = "This email is already registered.";
                    return View();
                }

                
                var newUser = new User
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    Role = role
                };

         
                db.Users.Add(newUser);
                db.SaveChanges();

              
                return RedirectToAction("Login");
            }
            return View();
        }

   
        public ActionResult Login(string role)
        {
            TempData["Role"] = role;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var role = TempData["Role"]?.ToString();
            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password && u.Role == role);

            if (user != null)
            {
                Session["UserID"] = user.UserID;
                Session["Role"] = user.Role;

                if (role == "Admin")
                {
                    return RedirectToAction("AdminDashboard", "Home");
                }
                else
                {
                    return RedirectToAction("UserDashboard", "Home");
                }
            }
            ViewBag.Message = "Invalid credentials!";
            return View();
        }

  
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}

