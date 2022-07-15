using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class SupplierService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public SupplierService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Supplier> GetSuppliers()
        {
            return _context.Suppliers.ToList();
        }
        public Supplier GetById(string id)
        {
            return _context.Suppliers.SingleOrDefault(e => e.SupplierId == id);
        }
    }
}
