using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookStores.Shared.Models;

namespace BookStores.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
        
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductsAggregationModel> GetAggregatedProductsFromJsonAsync()
        {
            var data = await _httpClient.GetFromJsonAsync<ProductsAggregationModel>("chart-aggregated-data.json");
            return data;
        }
    }
}
