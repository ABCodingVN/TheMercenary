using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IUserRepository userRepository;

        public UserController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.userRepository = new UserRepository(context);
        }

        [Route("users")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<User> users = userRepository.GetUsers();
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
            User user = userRepository.GetUserByID(id);
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
        [Route("create")]
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            User _user = userRepository.InsertUser(user);
            return _user == null? BadRequest(new
            {
                success = "false",
                message = "Register fail"
            }) : new JsonResult(new
            {
                success = "true",
                _user
            });
        }

    }
}
