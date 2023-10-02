using DapperApi.Repositories.CategoryRepository;
using DapperApi.Repositories.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProducts();
            return Ok(values);
        }
        [HttpGet("PorductJoinCategory")]
        public async Task<IActionResult> ProductCategoryJoin()
        {
            var values=await _productRepository.GetAllProductsJoin();
            return Ok(values);
        }
    }
}
