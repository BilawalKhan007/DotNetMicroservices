using Catalog.API.Entities;
using Catalog.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;
        private readonly ILogger<CatalogController> logger;

        public CatalogController(IProductsRepository _productsRepository, ILogger<CatalogController> _logger)
        {
            productsRepository = _productsRepository;
            logger = _logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Products>),(int) HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Products>>> GetAll()
        {
            return Ok(await productsRepository.GetAllProducts());
        }

    }
}
