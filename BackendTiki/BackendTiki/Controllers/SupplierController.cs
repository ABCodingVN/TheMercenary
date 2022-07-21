using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private ISupplierRepository supplierRepository;

        public SupplierController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.supplierRepository = new SupplierRepository(context);
        }

        [Route("Suppliers")]
        [HttpGet]
        public IActionResult GetSuppliers()
        {
            List<Supplier> Suppliers = supplierRepository.GetSuppliers();
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
            Supplier Supplier = supplierRepository.GetSupplierByID(id);
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
