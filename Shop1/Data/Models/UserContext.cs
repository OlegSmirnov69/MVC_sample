using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using Shop1.Data.Models;
using System.Data.Entity;

namespace Shop1.Data.Models
{
    public class UserContext : DbContext
    {
        //   public UserContext() : base(option)  { }

        public UserContext() :
        base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
