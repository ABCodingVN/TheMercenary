using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class OrderService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public OrderService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order GetById(string id)
        {
            return _context.Orders.SingleOrDefault(e => e.Orderid == id);
        }
    }
}
