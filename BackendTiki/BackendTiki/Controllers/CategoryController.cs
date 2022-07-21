using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
 
        private readonly IConfiguration _configuration;
        private ICategoryRepository categoryRepository;

        public CategoryController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.categoryRepository = new CategoryRepository(context);
        }
        [Route("categories")]
        [HttpGet]
        public IActionResult GetCategorys()
        {
            List<Category> categories = categoryRepository.GetCategorys();
            return categories.Count == 0 ? BadRequest(new
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
        public IActionResult GetById(string id)
        {
            Category category = categoryRepository.GetCategoryByID(id);
            return category == null ? BadRequest(new
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
