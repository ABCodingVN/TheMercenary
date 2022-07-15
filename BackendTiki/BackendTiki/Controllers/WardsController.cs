using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardsController : ControllerBase
    {
        private readonly WardsService _service;
        private readonly IConfiguration _configuration;
        public WardsController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new WardsService(configuration, context);
        }
        [Route("Wardss")]
        [HttpGet]
        public IActionResult GetWards()
        {
            List<Wards> Wardss = _service.GetWards();
            return Wardss.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Wardss
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Wards Wards = _service.GetById(id);
            return Wards == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Wards
            });
        }
    }
}
