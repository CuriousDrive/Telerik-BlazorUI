using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TelerikBlazorDemos.DataAccess;
using TelerikBlazorDemos.Models;
using OldProduct = TelerikBlazorDemos.Shared.Product;

namespace TelerikBlazorDemos.Services
{
    public class ProductService
    {
        private const string DefaultImageName = "no_image_available_small.gif";

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly AdventureContext _dbContext;
        private List<ProductBindingModel> productData = new List<ProductBindingModel>();
        private readonly JsonDataService _jsonDataService;

        public ProductService(IWebHostEnvironment hostingEnvironment, AdventureContext dbContext, JsonDataService jsonDataService)
        {
            _hostingEnvironment = hostingEnvironment;
            _dbContext = dbContext;
            _jsonDataService = jsonDataService;
        }

        public async Task<List<ProductBindingModel>> GetProductsAsync(int? categoryId = null, bool filterDefaultImages = true)
        {
            if (!productData.Any())
            {
                productData = (await _dbContext.Product.Include(p => p.ProductCategory).ToListAsync())
                    .OrderByDescending(p => p.SalesOrderDetail.Sum(o => o.LineTotal))
                    .Select(ProductBindingModel.ProductFunc)
                    .ToList();
            }

            return productData
                    .Where(p =>
                        (!categoryId.HasValue || p.ProductCategoryId == categoryId) &&
                        (!filterDefaultImages || p.ThumbnailPhotoFileName != DefaultImageName))
                    .ToList();
        }

        public async Task<ProductsAggregationModel> GetAggregatedProducts(int productCount = 3)
        {
            var bestProductsAggregation = (await _dbContext.SalesOrderDetail
               .Include(so => so.SalesOrder)
               .Include(so => so.Product)
               .ToListAsync())
               .Where(so => so.SalesOrder.OrderDate < new DateTime(2013, 1, 1))
               .GroupBy(so => so.ProductId)
               .OrderByDescending(sog => sog.Sum(g => g.LineTotal))
               .Take(productCount);

            var productAggregations = new List<ProductAggregationModel>();
            foreach (var productAggregation in bestProductsAggregation)
            {
                var productModel = new ProductAggregationModel();
                productModel.ProductName = productAggregation.First().Product.Name;
                var yearGroup = productAggregation.GroupBy(p => new
                {
                    p.SalesOrder.OrderDate.Year,
                    p.SalesOrder.OrderDate.Month
                });

                yearGroup = yearGroup.OrderBy(x => x.Key.Year).ThenBy(x => x.Key.Month);

                foreach (var productByYear in yearGroup)
                {
                    var productRevenueAndSales = new ProductRevenueAndSalesModel
                    {
                        Revenue = productByYear.Sum(py => py.LineTotal),
                        SalesCount = productByYear.Sum(py => py.OrderQty),
                        // Year = $"{productByYear.Key.Year} - M{productByYear.Key.Month}",
                        Category = new DateTime(1, productByYear.Key.Month, 1).ToString("MMM", CultureInfo.InvariantCulture)
                    };

                    productModel.ProductRevenueAndSales = productModel.ProductRevenueAndSales ?? new List<ProductRevenueAndSalesModel>();
                    productModel.ProductRevenueAndSales.Add(productRevenueAndSales);
                }

                productAggregations.Add(productModel);
            }

            var totalAggregations = new List<ProductRevenueAndSalesModel>();
            if (productAggregations.Any())
            {
                var dateGroups = productAggregations.SelectMany(x => x.ProductRevenueAndSales).GroupBy(x => x.Category);

                foreach (var group in dateGroups)
                {
                    var totalProductRevenueAndSales = new ProductRevenueAndSalesModel
                    {
                        Revenue = group.Sum(py => py.Revenue),
                        SalesCount = group.Sum(py => py.SalesCount),
                        Category = group.Key
                    };

                    totalAggregations.Add(totalProductRevenueAndSales);
                }
            }

            var result = new ProductsAggregationModel()
            {
                TotalAggregation = totalAggregations,
                ProductAggregation = productAggregations
            };

            return result;
        }

        public async Task<ProductsAggregationModel> GetAggregatedProductsFromJsonAsync()
        {
            var data = await _jsonDataService.GetJsonDataAsync<ProductsAggregationModel>("chart-aggregated-data.json");
            return data;
        }

        public Task<ProductBindingModel> AddAsync(ProductBindingModel productModel)
        {
            var lastId = productData.Max(p => p.ProductId);
            productModel.ProductId = lastId + 1;

            productData.Add(productModel);

            return Task.FromResult(productModel);
        }

        public Task UpdateAsync(ProductBindingModel productModel)
        {
            var productForUpdate = productData
                .Select((e, i) => new { Element = e, Index = i })
                .FirstOrDefault(x => x.Element.ProductId == productModel.ProductId);
            if (productForUpdate != null)
            {
                productData[productForUpdate.Index] = productModel;
            }

            return Task.CompletedTask;
        }

        public Task DeleteAsync(ProductBindingModel productModel)
        {
            var productForDelete = productData
                .Select((e, i) => new { Element = e, Index = i })
                .FirstOrDefault(x => x.Element.ProductId == productModel.ProductId);
            if (productForDelete != null)
            {
                productData.RemoveAt(productForDelete.Index);
            }

            return Task.CompletedTask;
        }

        public async Task<List<string>> GetProductNamesAsync()
        {
            var products = await GetProductsAsync();
            return products.Select(p => p.Name).ToList();
        }

        public ValueTask<List<OldProduct>> GetProductsFromJson()
        {
            List<OldProduct> products = new List<OldProduct>();
            var jsonPath = Path.Combine(_hostingEnvironment.WebRootPath, "products.json");

            if (!File.Exists(jsonPath))
            {
                return new ValueTask<List<OldProduct>>(products);
            }

            string demosJson = File.ReadAllText(jsonPath);
            return new ValueTask<List<OldProduct>>(JsonSerializer.Deserialize<List<OldProduct>>(demosJson));
        }
    }
}