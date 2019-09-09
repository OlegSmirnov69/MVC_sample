using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop1.Data.Models;
using Microsoft.AspNetCore.Identity;

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
                        adress = "Adress1",
                        isTop = true,
                        longitude = 24.4,
                        latitude = 42.2,
                        //item_category = new Category { CategoryName = "сars", desc = "four wheels and engine" }
                        item_category = GetCategories["Places"] 
                    },
                    new Item
                    {
                        name = "Cessna",
                        shortDesc = "Nice plane",
                        longDesc = "A place for long Description",
                        img = "/img/cessna.jpg",
                        adress = "Adress1",
                        isTop = true,
                        longitude = 24.4,
                        latitude = 42.2,
                        item_category = GetCategories["planes"]
                    },
                    new Item
                    {
                        name = "Boeing",
                        shortDesc = "Big plane",
                        longDesc = "A place for long Description",
                        img = "/img/boeing.jpg",
                        adress = "Adress1",
                        isTop = true,
                        longitude = 24.4,
                        latitude = 42.2,
                        item_category = GetCategories["planes"]
                    },
                    new Item
                    {
                        name = "BMW",
                        shortDesc = "A car",
                        longDesc = "A place for long Description",
                        img = "/img/bmw.jpg",
                        adress = "Adress1",
                        isTop = true,
                        longitude = 24.4,
                        latitude = 42.2,
                        item_category = GetCategories["cars"]
                    }

                    );
            //---------------------------------
            if (!content.Comments.Any())
            {
                content.Comments.AddRange(
                    new Comment
                    {
                        Date = "iPhone 6S",
                        Text = "Apple",

                    },
                    new Comment
                    {
                        Date = "Samsung Galaxy Edge",
                        Text = "Samsung",
                    },
                    new Comment
                    {
                        Date = "Lumia 950",
                        Text = "Microsoft",
                    }

                );

                content.SaveChanges();
            }
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
                        new Category { CategoryName = "Places", desc="A place for desc"},
                        new Category { CategoryName = "Misc", desc = "A place for desc"}
                    };

                    category_collection = new Dictionary<string, Category>();

                    foreach (Category category_element in category_list)
                        category_collection.Add(category_element.CategoryName, category_element);
                }

                return category_collection;
            }
        }

        //------------Comments
        

        //public static void InitComments(UserContext comm_content)
        //{

        //    //if (!content.Comments.Any())
        //    //    content.Comments.AddRange(GetCategories.Select(c => c.Value));


        //    if (!comm_content.Comments.Any())
        //        comm_content.AddRange(

        //            new Comment
        //            {
        //                date = DateTime.Now,
        //                text = "FirstComment",
        //                user_name = "User1",
        //                user_country = "USA1"
                        
        //            },
        //            new Comment
        //            {
        //                date = DateTime.Now,
        //                text = "SecondComment",
        //                user_name = "User2",
        //                user_country = "USA2"
        //            }

        //            );


        //    comm_content.SaveChanges();
        //}


    }
}
