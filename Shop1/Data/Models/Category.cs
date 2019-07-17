using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Category
    {
        public int id { set; get; }

        public string CategoryName { set; get; }

        public string desc { set; get; }

        public List<Item> item_list { set; get; }

    }
}
