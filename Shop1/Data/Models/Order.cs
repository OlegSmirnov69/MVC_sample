using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Order
    {

        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public DateTime order_time { get; set; }
        public List<OrderDetail> order_details { get; set; }


    }
}
