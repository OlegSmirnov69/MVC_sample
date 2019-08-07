using Shop1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop1.Data.Interfaces
{
    public interface IItems
    {
        IEnumerable<Item> GetAllItems { get;}
        IEnumerable<Item> GetTopItems { get; }
        Item getItem(int item_id);
    }
}
