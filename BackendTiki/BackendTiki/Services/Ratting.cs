using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class RattingService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public RattingService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<Ratting> GetRattings()
        {
            return _context.Rattings.ToList();
        }
        public Ratting GetById(string id)
        {
            return _context.Rattings.SingleOrDefault(e => e.RattingId == id);
        }
    }
}
