using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeeds
    {
        public static void SeedData(IMongoCollection<Products> Products)
        {
            bool dataExist = Products.Find(x => true).Any();
            if (!dataExist)
                Products.InsertManyAsync(GetData());
        }

        public static IEnumerable<Products> GetData()
        {
            return new List<Products>() { new Products() 
            { Id = "60bfb70e64d68b1064da9759", Name = "Name" , Category = "Name", Description = "Name", ImageFile = "Name", Price = 52.1, Summary ="Name" } };
        }
    }
}
