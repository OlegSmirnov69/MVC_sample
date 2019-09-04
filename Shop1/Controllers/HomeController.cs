using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;
using Shop1.ViewModels;

namespace Shop1.Controllers
{
    public class HomeController : Controller
    {

        private readonly IItems _itemRep;

        public HomeController(IItems itemRep)
        {
            _itemRep = itemRep;
        }
        //GET: Home
        //public ViewResult Index()
        //{
        //    var homeItems = new HomeViewModel
        //    {
        //        topItems = _itemRep.GetTopItems
        //    };
        //    return View(homeItems);
        //}

        public string Index()
        {
            string result = "Вы не авторизованы";
            if (User.Identity.IsAuthenticated)
            {
                result = "Ваш логин: " + User.Identity.Name;
            }
            return result;
        }

        public ViewResult About()
        {
            var homeItems = new HomeViewModel
            {
                topItems = _itemRep.GetTopItems
            };
            return View(homeItems);
        }


    }
}