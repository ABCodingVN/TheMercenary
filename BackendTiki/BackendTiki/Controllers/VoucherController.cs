using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly VoucherService _service;
        private readonly IConfiguration _configuration;
        public VoucherController(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _service = new VoucherService(configuration, context);
        }
        [Route("vouchers")]
        [HttpGet]
        public JsonResult GetOrders()
        {
            List<Voucher> vouchers = _service.GetVouchers();
            return vouchers.Count == 0 ? new JsonResult(new { success = "fails" }) : new JsonResult(vouchers);
        }
        [Route("get/{id}")]
        [HttpGet]
        public JsonResult GetById(string id)
        {
            Voucher voucher = _service.GetById(id);
            return voucher == null ? new JsonResult(new { success = "fails" }) : new JsonResult(voucher);
        }
    }
}
