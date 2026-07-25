using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductContext productContext, ILogger<ProductController> logger)
        {
            _productContext = productContext;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productContext.Products.Find(a => true).ToListAsync();
        }
    }
}
