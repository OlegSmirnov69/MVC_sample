using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Models;
using Shop1.Data.Interfaces;
//using System.Web.Mvc;
using Shop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop1.Controllers
{
    public class CartController : Controller
    {
        private readonly IItems _itemRep;
        private readonly Cart _cart;

        public CartController(IItems itemRep, Cart cart)
        {
            _itemRep = itemRep;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.GetCartItems();
            _cart.cart_items_list = items;

            var obj = new CartViewModel
            {
                cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _itemRep.GetAllItems.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _cart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
