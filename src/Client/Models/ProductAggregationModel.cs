using System;
using System.Collections.Generic;
using BookStores.Models;

namespace BookStores.Models
{
    public class ProductAggregationModel
    {
        public string ProductName { get; set; }

        public ICollection<ProductRevenueAndSalesModel> ProductRevenueAndSales { get; set; }
    }
}
