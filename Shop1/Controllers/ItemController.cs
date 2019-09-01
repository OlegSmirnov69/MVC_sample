using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;
using Shop1.ViewModels;

namespace Shop1.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItems _items;
        private readonly ICategories _categories;

        public ItemController (IItems iitems, ICategories icategories)
        {
            _items = iitems;
            _categories = icategories;
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
                if (string.Equals("cars", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _items.GetAllItems.Where(i => i.item_category.CategoryName.Equals("cars")).OrderBy(i => i.id);
                }
                else if (string.Equals("planes", category, StringComparison.OrdinalIgnoreCase))
                {
                    items = _items.GetAllItems.Where(i => i.item_category.CategoryName.Equals("planes")).OrderBy(i => i.id);
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

            return View(one_item);
        }

    }
}
