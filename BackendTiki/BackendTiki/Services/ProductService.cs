using BackendTiki.Access;
using BackendTiki.Models;
using Microsoft.AspNetCore.Mvc;

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
        public JsonResult GetLazyProducts(int pageNum, int pageSize)
        {
            var total = _context.Products.Count();
            var skip = pageSize * (pageNum - 1);
            var canPage = skip < total;

            if (!canPage)
                return null;
            List<Product> products = _context.Products.Skip(skip).Take(pageSize).ToList();

            return new JsonResult(new
            {
                success = true,
                products,
                pageTotal = total
            });
        }

        public Product GetById(string id)
        {
            return _context.Products.SingleOrDefault(e => e.ProductId == id);
        }
    }
}
