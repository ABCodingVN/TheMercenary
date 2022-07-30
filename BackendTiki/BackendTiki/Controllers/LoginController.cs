using BackendTiki.Access;
using BackendTiki.Dto;
using BackendTiki.Interface;
using BackendTiki.Models;
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
            User user = loginRepository.LoginByPhoneNumber(account);

            return user==null ?
                 Unauthorized(new
                 {
                     success = "false",
                     message = "Unauthorized access"
                 }) :
                new JsonResult(new { success = "true", token = user.UserId,name=user.Name });
        }
        
    }
}
