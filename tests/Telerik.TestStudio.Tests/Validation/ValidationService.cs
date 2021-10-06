using BookStores.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

namespace BookStores.Tests.Validation
{
    public class ValidationService
    {
        public bool ValidateProductPoints(List<ProductPoint> productPoints)
        {
            // Loading product information from the service
            HttpClient httpClient = new HttpClient();
            var productsAggregationModel = httpClient.GetFromJsonAsync<ProductsAggregationModel>("https://localhost:5001/chart-aggregated-data.json").GetAwaiter().GetResult();

            // Loading product from the captured data
            var productPoint = productPoints.Where(pp => pp.Category == "Jun").FirstOrDefault();

            // Validating if the captured data is matching with actual data from the service
            var productHL = productsAggregationModel.ProductAggregation.Where(pa => pa.ProductName == "AA").FirstOrDefault();
            var productRevenueAndSales = productHL.ProductRevenueAndSales.Where(prs => prs.Category == "Jun").FirstOrDefault();

            if (productRevenueAndSales.SalesCount == Convert.ToInt32(productPoint.AA))
                return true;

            return false;
        }
    }
}
