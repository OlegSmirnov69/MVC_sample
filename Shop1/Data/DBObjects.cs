using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop1.Data.Models;

namespace Shop1.Data
{
    public class DBObjects
    {
        //creating/adding/initializating objects of DB
        public static void Init(AppDBContent content)
        {

            if (!content.DBCategory.Any())
                content.DBCategory.AddRange(GetCategories.Select(c => c.Value));


            if (!content.DBItem.Any())
                content.AddRange(

                    new Item
                    {
                        name = "Tesla",
                        shortDesc = "Car from Musk",
                        longDesc = "A place for long Description",
                        img = "/img/tesla.jpg",
                        price = 54000,
                        isTop = true,
                        available = true,
                        //item_category = new Category { CategoryName = "сars", desc = "four wheels and engine" }
                        item_category = GetCategories["cars"] 
                    },
                    new Item
                    {
                        name = "Cessna",
                        shortDesc = "Nice plane",
                        longDesc = "A place for long Description",
                        img = "/img/cessna.jpg",
                        price = 25000,
                        isTop = true,
                        available = true,
                        item_category = GetCategories["planes"]
                    },
                    new Item
                    {
                        name = "Boeing",
                        shortDesc = "Big plane",
                        longDesc = "A place for long Description",
                        img = "/img/boeing.jpg",
                        price = 62000,
                        isTop = false,
                        available = false,
                        item_category = GetCategories["planes"]
                    },
                    new Item
                    {
                        name = "BMW",
                        shortDesc = "A car",
                        longDesc = "A place for long Description",
                        img = "/img/bmw.jpg",
                        price = 14000,
                        isTop = false,
                        available = true,
                        item_category = GetCategories["cars"]
                    }

                    );
            
            content.SaveChanges();
        }

        public static Dictionary<string, Category> category_collection;

        public static Dictionary<string, Category> GetCategories
        {
            get
            {
                if (category_collection == null)
                {
                    var category_list = new Category[]
                    {
                        new Category { CategoryName = "сars", desc="four wheels and engine"},
                        new Category { CategoryName = "planes", desc = "wings and engine"}
                    };

                    category_collection = new Dictionary<string, Category>();

                    foreach (Category category_element in category_list)
                        category_collection.Add(category_element.CategoryName, category_element);
                }

                return category_collection;
            }
        }
    }
}
