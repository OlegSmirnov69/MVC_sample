using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;

namespace Shop1.Data.Mocks
{
    public class MockCategory : ICategories
    {
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Cars", desc="four wheels and engine"},
                    new Category { CategoryName = "planes", desc = "wings and engine"}
                };
            }
            
        }
    }
}
