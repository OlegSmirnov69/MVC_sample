using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Item
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public string adress { set; get; }

        public bool isTop { set; get; }

        public double longitude { set; get; }
        public double latitude { set; get; }

        //public int category_id { set; get; }

        public virtual Category item_category { set; get; }
    }
}
