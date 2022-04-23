using BackendTiki.Access;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class UserService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public UserService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetById(string id)
        {
            return _context.Users.SingleOrDefault(e => e.UserId == id);
        }
    }
}
