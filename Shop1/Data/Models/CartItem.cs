using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class CartItem
    {
        public int id { get; set; }
        public Item item { get; set; }
        public string adress { get; set; }

        public string cart_id { get; set; }
    }
}
