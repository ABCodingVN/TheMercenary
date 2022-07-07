using BackendTiki.Access;
using BackendTiki.Dto;
using BackendTiki.Models;
using Microsoft.AspNetCore.Mvc;
using BackendTiki.Access.StaticFunction;

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
        {  List<Product> products = _context.Products.ToList();
            if (products.Count > 2)
            {
                int left = 0;
                int right = products.Count - 1;
                Sort.quickSort(products, products[left], products[right], left, right);
            }
           
            return products;
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

        public List<Product> GetBySearch(SearchProducts search)
        {
            List<Product> products = _context.Products.Select(e=>e).Where(e=>e.Name.Contains(search.InputSearch)).ToList();
            return products;
        }

        public Object GetDetailById(string id)
        {
            try
            {
                Product product = _context.Products.SingleOrDefault(e => e.ProductId == id);
                if (product != null)
                {
                    Supplier supplier = _context.Suppliers.SingleOrDefault(e => e.SupplierId == product.SupplierId);
                    Ratting ratting = _context.Rattings.SingleOrDefault(e => e.RatingId == product.RattingId);

                    return new
                    {
                        product,
                        supplier,
                        ratting
                    };
                }
                return null;

            }
            catch(Exception e)
            {
                return null;
            }
          
        }
    }
}
