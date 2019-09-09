using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Cart
    {

        private readonly AppDBContent appDB;

        public Cart(AppDBContent appDBContent)
        {
            this.appDB = appDBContent;
        }

        public string cart_id { get; set; }

        public List<CartItem> cart_items_list { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string cartid = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", cartid);

            return new Cart(context) { cart_id = cartid };
        }

        public void AddToCart(Item item)
        {
            appDB.DBCartItem.Add(new CartItem
            {
                cart_id = cart_id,
                item = item,
                adress = item.adress
            }
                );

            appDB.SaveChanges();
        }

        public List<CartItem> GetCartItems()
        {
            return appDB.DBCartItem.Where(c => c.cart_id == cart_id).Include(s => s.item).ToList();
        }
    }
}
