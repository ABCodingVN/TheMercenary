using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        private readonly IConfiguration _configuration;
        public ProductController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ProductService(configuration, context);
        }
        [Route("get")]
        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = _service.GetProducts();
            return products.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                products
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Product product = _service.GetById(id);
            return product == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                product
            });
        }

    }
}
