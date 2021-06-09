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
        public CatalogContext(IConfiguration Configuration)
        {
            var client = new MongoClient(Configuration.GetValue<String>("DatabaseSettings:ConnectionString"));
            var Database = client.GetDatabase(Configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = Database.GetCollection<Products>(Configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogContextSeeds.SeedData(Products);

        }
        public IMongoCollection<Products> Products { get; }
    }
}
