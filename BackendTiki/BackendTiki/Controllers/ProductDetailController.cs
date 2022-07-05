using Microsoft.AspNetCore.Mvc;
using BackendTiki.Services;
using BackendTiki.Access;
using BackendTiki.Models;
namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly ProductDetailService _service;
        private readonly IConfiguration _configuration;
        public ProductDetailController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ProductDetailService(configuration, context);
        }

        [Route("detail/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            ProductDetail product = _service.GetById(id);
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
