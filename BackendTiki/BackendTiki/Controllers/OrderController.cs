using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IOrderRepository orderRepository;

        public OrderController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.orderRepository = new OrderRepository(context);
        }

        [Route("orders")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<Order> orders = orderRepository.GetOrders();
            return orders.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                orders
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Order order = orderRepository.GetOrderByID(id);
            return order == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                order
            });
        }
    }
}
