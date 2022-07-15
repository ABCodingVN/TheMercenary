using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly DistrictService _service;
        private readonly IConfiguration _configuration;
        public DistrictController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new DistrictService(configuration, context);
        }
        [Route("vouchers")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<Voucher> Districts = _service.GetDistricts();
            return Districts.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Districts
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            District District = _service.GetById(id);
            return District == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                District
            });
        }
    }
}
