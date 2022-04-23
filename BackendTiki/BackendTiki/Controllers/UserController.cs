using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new UserService(configuration, context);
        }
        [Route("users")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<User> users = _service.GetUsers();
            return users.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                users
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            User user = _service.GetById(id);
            return user == null ? BadRequest(new
            {
                success= "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                user
            });
        }

    }
}
