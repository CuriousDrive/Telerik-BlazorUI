using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using BookStores.Tests.Models;
using System.Threading.Tasks;
using System.Linq;

namespace BookStores.Tests.Validation
{
    public class ValidationService
    {
        public bool ValidateProductPoints(List<ProductPoint> productPoints)
        {
            HttpClient httpClient = new HttpClient();
            var productsAggregationModel = httpClient.GetFromJsonAsync<ProductsAggregationModel>("https://localhost:5001/chart-aggregated-data.json").GetAwaiter().GetResult();

            foreach(var productPoint in productPoints)
            {
                if(productPoint.Category == "Jun")
                {
                    var productHL = productsAggregationModel.ProductAggregation.Where(pa => pa.ProductName == "AA").FirstOrDefault();
                    var productRevenueAndSales = productHL.ProductRevenueAndSales.Where(prs => prs.Category == "Jun").FirstOrDefault();

                    if (productRevenueAndSales.SalesCount == Convert.ToInt32(productPoint.AA))
                        return true;
                }
            }

            return false;
        }
    }
}
