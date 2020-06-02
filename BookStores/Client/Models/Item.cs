using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Client.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public Item()
        {

        }

        public Item(int itemId, string itemName)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
        }
    }
}
