using BackendTiki.Access;
using BackendTiki.Dto;
using BackendTiki.Models;

namespace BackendTiki.Services
{
    public class LoginService
    {

        private readonly Context _context;
        private readonly IConfiguration _configuration;
        public LoginService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public string LoginByPhoneNumber(LoginDTO account)
        {
            User user = _context.Users.FirstOrDefault(u =>
            u.Password.Equals(account.Password) &&
            u.PhoneNumber.Equals(account.PhoneNumber));
            if (user == null)
            {
                return null;
            }
            return user.PhoneNumber + user.Gmail;
        }
    }
}
