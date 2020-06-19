using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Client.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Product()
        { 
        
        }

        public Product(int productId, string productName)
        {
            this.ProductId = productId;
            this.ProductName = productName;
        }
    }
}
