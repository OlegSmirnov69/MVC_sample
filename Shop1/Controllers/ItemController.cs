using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;
using Shop1.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Shop1.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItems _items;
        private readonly ICategories _categories;
        //-----------------------------
        private readonly UserManager<User> _userManager;

        public ItemController (IItems iitems, ICategories icategories, UserManager<User> userManager)
        {
            _items = iitems;
            _categories = icategories;
            _userManager = userManager;
        }

        [Route("Item/ShowList")]
        [Route("Item/ShowList/{category}")]
        public ViewResult ShowList(string category)
        {

            string _category = category;
            IEnumerable<Item> items = null;
            string curr_category = "";
            if(string.IsNullOrEmpty(category))
            {
                items = _items.GetAllItems.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("Historical", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _items.GetAllItems.Where(i => i.item_category.CategoryName.Equals("Historical")).OrderBy(i => i.id);
                }
                else if (string.Equals("Food", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _items.GetAllItems.Where(i => i.item_category.CategoryName.Equals("Food")).OrderBy(i => i.id);
                }
                else if (string.Equals("Misc", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _items.GetAllItems.Where(i => i.item_category.CategoryName.Equals("Misc")).OrderBy(i => i.id);
                }
                curr_category = _category;

            }

            var item_obj = new ItemsListViewModel
            {
                allItems = items,
                currentCategory = curr_category
            };

            ViewBag.Title = "Items List";
            //оголошуєммо змінну і присвоюємо їй результат фунції по отримання всіх ітемів
            //ItemsListViewModel allitems = new ItemsListViewModel();
            //allitems.getallItems = _items.GetAllItems;
            //allitems.currentCategory = Convert.ToString(_categories.GetAllCategories.First());

            return View(item_obj);

            
            
        }

        public ViewResult ShowItem(int id)
        {
            int _id = id;
            Item item = null;
            item = _items.getItem(_id);

            var one_item = new ItemViewModel
            {
                getitem = item
            };

            ViewBag.Title = "Item";
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            ViewBag.username = _userManager.GetUserName(HttpContext.User);
            

            return View(one_item);
        }

    }
}
