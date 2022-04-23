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
        [Route("opt")]
        [HttpGet]
        public void getOPT()
        {
            _service.SendOTP();
            
        }
        [Route("create")]
        [HttpGet]
        public void createOPT()
        {
            _service.CreateOPT();

        }
    }
}
