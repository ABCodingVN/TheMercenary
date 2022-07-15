using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class ProvinceService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public ProvinceService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Province> GetProvinces()
        {
            return _context.Province.ToList();
        }
        public Province GetById(string id)
        {
            return _context.Province.SingleOrDefault(e => e.ProvinceId == id);
        }
    }
}
