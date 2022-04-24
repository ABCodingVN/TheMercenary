using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class VoucherService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public VoucherService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Voucher> GetVouchers()
        {
            return _context.Vouchers.ToList();
        }
        public Voucher GetById(string id)
        {
            return _context.Vouchers.SingleOrDefault(e => e.VoucherId == id);
        }
    }
}
