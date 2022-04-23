using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class CategoryService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public CategoryService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category GetById(string id)
        {
            return _context.Categories.SingleOrDefault(e => e.CategoryId == id);
        }
    }
}
