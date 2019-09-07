using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Comment
    {
        public int id { set; get; } 
        public DateTime date { set; get; }
        public string text { set; get; }
        public string user_name { set; get; }
        public string user_country { set; get; }
        //public int item { set; get; }
        //public virtual Item item_id { set; get; }


    }
}
