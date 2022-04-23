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
        public IActionResult GetOrders()
        {
            List<Order> orders = _service.GetOrders();
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
            Order order = _service.GetById(id);
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
