using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;

namespace Shop1.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent appDBContent;
        private readonly Cart cart;

        public OrdersRepository(AppDBContent appDB , Cart cart)
        {
            this.appDBContent = appDB;
            this.cart = cart;
        }

        public void createOrder(Order order)
        {
            order.order_time = DateTime.Now;
            appDBContent.DBOrder.Add(order);

            var items = cart.cart_items_list;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    item_id = el.item.id,
                    order_id = order.id,
                    price = el.item.price
                };

                appDBContent.DBOrderDetail.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
