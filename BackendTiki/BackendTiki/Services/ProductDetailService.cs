using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class ProductDetailService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ProductDetailService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }

        public ProductDetail GetById(string id)
        {
            try
            {
                return _context.ProductDetails.SingleOrDefault(e => e.ProductDetailId == id);
            }
            catch(Exception e)
            {
                return null;
            }
        }

    }
}
