using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly ProvinceService _service;
        private readonly IConfiguration _configuration;
        public ProvinceController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new ProvinceService(configuration, context);
        }
        [Route("Provinces")]
        [HttpGet]
        public IActionResult GetProvinces()
        {
            List<Province> Provinces = _service.GetProvinces();
            return Provinces.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Provinces
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Province Province = _service.GetById(id);
            return Province == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Province
            });
        }
    }
}
