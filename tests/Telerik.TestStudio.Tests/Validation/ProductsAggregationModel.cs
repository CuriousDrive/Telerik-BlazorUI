using System.Collections.Generic;

namespace BookStores.Tests.Models
{
    public class ProductsAggregationModel
    {
        public ICollection<ProductAggregationModel> ProductAggregation { get; set; }
        public ICollection<ProductRevenueAndSalesModel> TotalAggregation { get; set; }
    }
}
