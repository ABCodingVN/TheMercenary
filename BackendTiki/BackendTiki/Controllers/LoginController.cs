using BackendTiki.Access;
using BackendTiki.Dto;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _service;
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new LoginService(configuration, context);
        }
        [Route("login")]
        [HttpPost]
        public IActionResult LoginByPhoneNumber(LoginDTO account)
        {
            string result = _service.LoginByPhoneNumber(account);

            return String.IsNullOrEmpty(result) ?
                 Unauthorized(new
                 {
                     success = "false",
                     message = "Unauthorized access"
                 }) :
                new JsonResult(new { success = "true", token = result });
        }
    }
}
