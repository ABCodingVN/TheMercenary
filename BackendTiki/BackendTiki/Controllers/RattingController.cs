using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RattingController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IRattingRepository rattingRepository;

        public RattingController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.rattingRepository = new RattingRepository(context);
        }

        [Route("Rattings")]
        [HttpGet]
        public IActionResult GetRattings()
        {
            List<Ratting> Rattings = rattingRepository.GetRattings();
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
            Ratting Ratting = rattingRepository.GetRattingByID(id);
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
