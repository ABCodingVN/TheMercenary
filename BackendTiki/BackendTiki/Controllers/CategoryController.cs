using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _service;
        private readonly IConfiguration _configuration;
        public CategoryController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new CategoryService(configuration, context);
        }
        [Route("categories")]
        [HttpGet]
        public JsonResult GetCategorys()
        {
            List<Category> categories = _service.GetCategories();
            return categories.Count == 0 ? new JsonResult(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                categories
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public JsonResult GetById(string id)
        {
            Category category = _service.GetById(id);
            return category == null ? new JsonResult(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                category
            });
        }

    }
}
