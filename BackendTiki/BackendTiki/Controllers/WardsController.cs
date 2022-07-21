using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IWardsRepository wardsRepository;

        public WardsController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.wardsRepository = new WardsRepository(context);
        }

        [Route("Wardss")]
        [HttpGet]
        public IActionResult GetWards()
        {
            List<Wards> Wardss = wardsRepository.GetWards();
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
            Wards Wards = wardsRepository.GetWardsByID(id);
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
