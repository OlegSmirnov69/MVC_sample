using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;


namespace Shop1.Data.Mocks
{
    //мок реалізує функції інтерфейсів
    public class MockItem : IItems
    {
        // змінна яка витягує категорію з інтерфейса категорій
        private readonly ICategories _category = new MockCategory();

        public IEnumerable<Item> GetAllItems
        {
            get
            {
                return new List<Item>
                {
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
                        item_category = _category.GetAllCategories.Last()
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
                        item_category = _category.GetAllCategories.First()
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
                        item_category = _category.GetAllCategories.First()
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
                        item_category = _category.GetAllCategories.Last()
                    }
                };
            }
            
        }
        public IEnumerable<Item> GetTopItems { get ; set; }

        public Item getItem(int item_id)
        {
            throw new NotImplementedException();
        }
    }
}
