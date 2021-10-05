using System;
using System.Collections.Generic;
using BookStores.Shared.Models;

namespace BookStores.Shared.Models
{
    public class ProductAggregationModel
    {
        public string ProductName { get; set; }
        public ICollection<ProductRevenueAndSalesModel> ProductRevenueAndSales { get; set; }
    }
}
