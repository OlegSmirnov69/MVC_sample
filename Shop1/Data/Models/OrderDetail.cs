using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int item_id { get; set; }
        public uint price { get; set; }
        public virtual Item item { get; set; }
        public virtual Order order { get; set; }
    }
}
