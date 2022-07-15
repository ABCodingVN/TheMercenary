using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly SupplierService _service;
        private readonly IConfiguration _configuration;
        public SupplierController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new SupplierService(configuration, context);
        }
        [Route("Suppliers")]
        [HttpGet]
        public IActionResult GetSuppliers()
        {
            List<Supplier> Suppliers = _service.GetSuppliers();
            return Suppliers.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Suppliers
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Supplier Supplier = _service.GetById(id);
            return Supplier == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                Supplier
            });
        }
    }
}
