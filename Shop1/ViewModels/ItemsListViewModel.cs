using Shop1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> getallItems { get; set; }
        public string currentCategory { get; set; }

    }
}
