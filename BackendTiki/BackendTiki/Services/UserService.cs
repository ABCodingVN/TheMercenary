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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> main

        public User CreateUser(User user)
        {
            User _user= _context.Users.SingleOrDefault(e => e.PhoneNumber == user.PhoneNumber);
            if ( _user == null)
            {
                Guid g = Guid.NewGuid();
                user.UserId = g.ToString();
                _context.Users.Add(user);
                if (_context.SaveChanges()>0)
                    return user;
                return null;
            }
            return null;
        }
<<<<<<< HEAD
=======
=======
>>>>>>> main
>>>>>>> main
    }
}
