using BackendTiki.Access;
using BackendTiki.Dto;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private ILoginRepository loginRepository;

        public LoginController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.loginRepository = new LoginRepository(context);
        }


        [Route("login")]
        [HttpPost]
        public IActionResult LoginByPhoneNumber(LoginDTO account)
        {
            string result = loginRepository.LoginByPhoneNumber(account);

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
