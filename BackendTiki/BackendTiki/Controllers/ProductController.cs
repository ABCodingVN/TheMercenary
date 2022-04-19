using BackendTiki.Access;
using BackendTiki.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
   
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ProductController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;
        }
        [Route("products")]
        [HttpGet]
        public JsonResult GetProducts()
        {
            List<Product> products = _context.Products.ToList();
            if(products.Count == 0)
                return new JsonResult(new {success="fails"
                });
            return new JsonResult(products);
        }
    }
}
