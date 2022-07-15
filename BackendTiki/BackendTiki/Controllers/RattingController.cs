using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RattingController : ControllerBase
    {
        private readonly RattingService _service;
        private readonly IConfiguration _configuration;
        public RattingController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new RattingService(configuration, context);
        }
        [Route("Rattings")]
        [HttpGet]
        public IActionResult GetRattings()
        {
            List<Ratting> Rattings = _service.GetRattings();
            return Rattings.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Rattings
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Ratting Ratting = _service.GetById(id);
            return Ratting == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Ratting
            });
        }
    }
}
