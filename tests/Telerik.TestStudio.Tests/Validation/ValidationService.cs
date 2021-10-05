using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using BookStores.Tests.Models;

namespace BookStores.Tests.Validation
{
    public class ValidationService
    {
        public static bool ValidateProductPoints(List<ProductPoint> productPoints)
        {
            HttpClient httpClient = new HttpClient();
            var productsAggregationModel = httpClient.GetFromJsonAsync<ProductsAggregationModel>("https://localhost:5001/chart-aggregated-data.json");

            foreach(var productPoint in productPoints)
            {
                if(productPoint.ML != null)
                {

                }
            }

            return true;
        }
    }
}
