using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Dto;
using BackendTiki.Interface;
using BackendTiki.Repository;
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
        private IProductRepository productRepository;

        public ProductController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.productRepository = new ProductRepository(context);
        }
        [Route("all")]
        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = productRepository.GetProducts();
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
            List<Product> result= productRepository.GetLazyProducts(pageNum,pageSize);
            return result.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                result
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Product product = productRepository.GetProductByID(id);
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
            Object detail = productRepository.GetDetailProductByID(id);
            return detail == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                detail
            });
           
        }
        [Route("search")]
        [HttpPost]
        public IActionResult SearchProduct(SearchProducts search)
        {
            List<Product> products = productRepository.GetBySearch(search);
            return  new JsonResult(new
            {
                success = "true",
                products
            });
        }

    }
}
