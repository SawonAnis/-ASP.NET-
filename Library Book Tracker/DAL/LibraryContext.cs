﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LibraryContext : DbContext
    {
    public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }
    }

 

      
    
}
