using BackendTiki.Access;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        private readonly OTPService _service;
        private readonly IConfiguration _configuration;
        public OTPController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new OTPService(configuration, context);
        }
        [Route("sendOpt/{phone}")]
        [HttpGet]
        public IActionResult getOPT(string phone)
        {

            int OPT = _service.SendOTP(phone);
            return OPT == -1 ?
               BadRequest(new
               {
                   success = "false",
                   message = "Can not send OTP to mobile phone"
               }) :
                new JsonResult(new
                {
                    success = "true",
                    OPTNumber = OPT
                });


        }
        [Route("create")]
        [HttpGet]
        public void createPhoneOPT()
        {
            _service.CreateOPT();

        }
    }
}
