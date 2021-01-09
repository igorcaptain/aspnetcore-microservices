using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "iPhone 12",
                    Summary = "This is very nice smartphone (definitely not)",
                    Description = "some of description",
                    ImageFile = "product-1.png",
                    Category = "Smartphone",
                    Price = 800M
                },
                new Product()
                {
                    Name = "Google Pixel 5",
                    Summary = "This is very nice smartphone (definitely not too)",
                    Description = "some of description",
                    ImageFile = "product-2.png",
                    Category = "Smartphone",
                    Price = 900M
                },
                new Product()
                {
                    Name = "Samsung Galaxy S20",
                    Summary = "This is very nice smartphone",
                    Description = "some of description",
                    ImageFile = "product-3.png",
                    Category = "Smartphone",
                    Price = 900M
                }
            };
        }
    }
}
