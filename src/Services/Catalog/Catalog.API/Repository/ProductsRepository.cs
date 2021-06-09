using Catalog.API.Data;
using Catalog.API.Entities;
using Catalog.API.Repository.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ICatalogContext ICatalogContext;

        public ProductsRepository(ICatalogContext _ICatalogContext)
        {
            ICatalogContext = _ICatalogContext ?? throw new ArgumentNullException(nameof(_ICatalogContext));
        }
        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            var test =  await ICatalogContext.Products.Find(x => true).ToListAsync();
            return test;
        }
    }
}
