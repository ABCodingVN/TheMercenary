using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class DistrictService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public DistrictService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<District> GetDistricts()
        {
            return _context.District.ToList();
        }
        public District GetById(string id)
        {
            return _context.District.SingleOrDefault(e => e.DistrictId == id);
        }
    }
}
