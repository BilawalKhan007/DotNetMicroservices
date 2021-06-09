using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repository.Interfaces
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Products>> GetAllProducts();
    }
}
