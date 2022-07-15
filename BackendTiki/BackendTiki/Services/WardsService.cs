using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class WardsService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public WardsService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Wards> GetWards()
        {
            return _context.Wards.ToList();
        }
        public Wards GetById(string id)
        {
            return _context.Wards.SingleOrDefault(e => e.WardsId == id);
        }
    }
}
