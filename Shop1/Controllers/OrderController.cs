using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;

namespace Shop1.Controllers
{
    public class OrderController : Controller
    {

        private readonly IAllOrders allOrders;
        private readonly Cart cart;

        public OrderController(IAllOrders allOrders, Cart cart)
        {
            this.allOrders = allOrders;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

    }
}
