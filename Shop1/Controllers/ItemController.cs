using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop1.Data.Interfaces;

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

        public ViewResult ShowList()
        {
            //оголошуєммо змінну і присвоюємо їй результат фунції по отримання всіх ітемів
            var items = _items.GetAllItems;
            return View(items);
        }
    }
}
