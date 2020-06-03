using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Client.Models
{
    public class Item
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public bool Purchased { get; set; }
        public bool OutOfStock { get; set; }

        public Item()
        {

        }

        public Item(string itemId, string itemName)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
        }

        public Item(string itemId, string itemName, bool purchased, bool outOfStock)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
            this.Purchased = purchased;
            this.OutOfStock = outOfStock;
        }
    }
}
