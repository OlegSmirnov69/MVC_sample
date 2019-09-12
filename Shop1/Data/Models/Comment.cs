using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Models
{
    public class Comment
    {
        public int Id { set; get; } 
        public string Date { set; get; }
        public string Text { set; get; }
        public string User { set; get; }
        public string UserCountry { set; get; }
        //public string Name { set; get; }
        //public string Country { set; get; }
        //public int item { set; get; }
        //public virtual Item item_id { set; get; }


    }
}
