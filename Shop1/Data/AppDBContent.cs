using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop1.Data.Models;

namespace Shop1.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Item> DBItem { get; set; }
        public DbSet<Category> DBCategory { get; set; }
        public DbSet<CartItem> DBCartItem { get; set; }
        public DbSet<Order> DBOrder { get; set; }
        public DbSet<OrderDetail> DBOrderDetail { get; set; }
        

    }
}
