using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Dto;
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
        [Route("all")]
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
        [Route("get/{pageNum}/{pageSize}")]
        [HttpGet]
        public IActionResult GetLazyProducts(int pageNum,int pageSize)
        {
            var result= _service.GetLazyProducts(pageNum,pageSize);
            return result == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : result;
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
        [Route("detail/{id}")]
        [HttpGet]
        public IActionResult GetDetailById(string id)
        {
            Object detail = _service.GetDetailById(id);
           /* return detail == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                detail
            });*/
           return new JsonResult(new
           {
               success = "true",
               detail
           }); 
        }
        [Route("search")]
        [HttpPost]
        public IActionResult SearchProducr(SearchProducts search)
        {
            List<Product> products = _service.GetBySearch(search);
            return  new JsonResult(new
            {
                success = "true",
                products
            });
        }

    }
}
