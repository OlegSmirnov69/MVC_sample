using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop1.Data.Interfaces;
using Shop1.Data.Models;

namespace Shop1.Data.Repository
{
    public class ItemRepository : IItems
    {
        private readonly AppDBContent appDB;

        public ItemRepository(AppDBContent appDBContent)
        {
            this.appDB = appDBContent;
        }

        public IEnumerable<Item> GetAllItems => appDB.DBItem.Include(c => c.item_category);

        public IEnumerable<Item> GetTopItems => appDB.DBItem.Where(top => top.isTop).Include(c => c.item_category);

        public Item getItem(int item_id) => appDB.DBItem.FirstOrDefault(i => i.id == item_id);
        
    }
}
