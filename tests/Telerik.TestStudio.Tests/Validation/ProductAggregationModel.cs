using System;
using System.Collections.Generic;
using BookStores.Tests.Models;

namespace BookStores.Tests.Models
{
    public class ProductAggregationModel
    {
        public string ProductName { get; set; }
        public ICollection<ProductRevenueAndSalesModel> ProductRevenueAndSales { get; set; }
    }
}
