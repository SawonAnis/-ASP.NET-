using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
    public  LibraryContext _context = new LibraryContext();

    
        public bool ValidateUser(string username, string password)
        {
         
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return false;

       
            return user.Password == password;
        }
      
    
        public  class AuthService
        {
            public static bool Logout()
            {
               
                return true; 
            }
        }
    }

}


