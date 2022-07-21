using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IProvinceRepository provinceRepository;

        public ProvinceController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.provinceRepository = new ProvinceRepository(context);
        }

        [Route("Provinces")]
        [HttpGet]
        public IActionResult GetProvinces()
        {
            List<Province> Provinces = provinceRepository.GetProvices();
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
            Province Province = provinceRepository.GetProviceByID(id);
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
