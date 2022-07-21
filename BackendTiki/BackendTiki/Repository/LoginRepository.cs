
using BackendTiki.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Dto;
using BackendTiki.Access;
namespace BackendTiki.Repository
{
    public class LoginRepository : ILoginRepository, IDisposable
    {
        private Context context;

        public LoginRepository(Context context)
        {
            this.context = context;
        }
        public string LoginByPhoneNumber(LoginDTO account)
        {
            User user = context.Users.FirstOrDefault(u =>
            u.Password.Equals(account.Password) &&
            u.PhoneNumber.Equals(account.PhoneNumber));
            if (user == null)
            {
                return null;
            }
            return user.PhoneNumber + user.Gmail;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
