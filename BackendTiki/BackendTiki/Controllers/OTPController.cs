using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IOTPRepository OTPRepository;

        public OTPController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.OTPRepository = new OTPRepository(context);
        }

        [Route("sendOpt/{phone}")]
        [HttpGet]
        public IActionResult getOPT(string phone)
        {

            int OPT = OTPRepository.getOPT(phone);
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
   
    }
}
