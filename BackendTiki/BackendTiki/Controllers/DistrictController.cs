using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private IDistrictRepository districtRepository;

        public DistrictController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.districtRepository = new DistrictRepository(context);
        }
        [Route("vouchers")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<District> Districts = districtRepository.GetDistricts();
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
            District District = districtRepository.GetById(id);
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
