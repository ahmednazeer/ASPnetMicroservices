using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public  CatalogContext(IConfiguration configuration)
        {
            
            var catalogClient = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = catalogClient.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            //seeding data
            InsertManyProducts();
        }

        private async Task InsertManyProducts()
        {
           await CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
