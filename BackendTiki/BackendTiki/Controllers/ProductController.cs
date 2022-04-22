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
        public ProductController(IConfiguration configuration,Context context)
        {
            _configuration = configuration;
            _service= new ProductService(configuration, context);
        }
        [Route("get")]
        [HttpGet]
        public JsonResult GetProducts()
        {
            List<Product> products = _service.GetProducts();
            return products.Count == 0? new JsonResult(new {success="fails"}): new JsonResult(products);
        }
        [Route("get/{id}")]
        [HttpGet]
        public JsonResult GetById(string id)
        {
            Product product = _service.GetById(id);
            return product==null ? new JsonResult(new { success = "fails" }) : new JsonResult(product);
        }
     
    }
}
