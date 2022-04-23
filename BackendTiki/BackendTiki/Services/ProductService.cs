using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class ProductService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ProductService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetById(string id)
        {
            return _context.Products.SingleOrDefault(e => e.ProductId == id);
        }
    }
}
