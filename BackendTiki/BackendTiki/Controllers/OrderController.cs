using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _service;
        private readonly IConfiguration _configuration;
        public OrderController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new OrderService(configuration, context);
        }
        [Route("orders")]
        [HttpGet]
        public JsonResult GetOrders()
        {
            List<Order> orders = _service.GetOrders();
            return orders.Count == 0 ? new JsonResult(new { success = "fails" }) : new JsonResult(orders);
        }
        [Route("get/{id}")]
        [HttpGet]
        public JsonResult GetById(string id)
        {
            Order order = _service.GetById(id);
            return order == null ? new JsonResult(new { success = "fails" }) : new JsonResult(order);
        }
    }
}
