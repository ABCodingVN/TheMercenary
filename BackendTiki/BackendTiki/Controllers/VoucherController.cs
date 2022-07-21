using BackendTiki.Access;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BackendTiki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private IVoucherRepository voucherRepository;

        public VoucherController(IConfiguration configuration, Context context)
        {
            this._configuration = configuration;
            this.voucherRepository = new VoucherRepository(context);
        }

        [Route("vouchers")]
        [HttpGet]
        public IActionResult GetOrders()
        {
            List<Voucher> vouchers = voucherRepository.GetVouchers();
            return vouchers.Count == 0 ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                vouchers
            });
        }
        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetById(string id)
        {
            Voucher voucher = voucherRepository.GetVoucherByID(id);
            return voucher == null ? BadRequest(new
            {
                success = "false",
                message = "Not Found"
            }) : new JsonResult(new
            {
                success = "true",
                voucher
            });
        }
    }
}
