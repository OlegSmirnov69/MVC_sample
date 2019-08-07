using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;

namespace Shop1.Data.Repository
{
    public class CategoryRepository : ICategories
    {
        private readonly AppDBContent appDB;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDB = appDBContent;
        }
        public IEnumerable<Category> GetAllCategories => appDB.DBCategory;
    }
}
