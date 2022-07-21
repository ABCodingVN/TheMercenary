
using BackendTiki.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BackendTiki.Models;
using BackendTiki.Interface;
using BackendTiki.Access;
namespace BackendTiki.Repository
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private Context context;

        public UserRepository(Context context)
        {
            this.context = context;
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserByID(string id)
        {   User User = context.Users.Find(id);
            if(User == null)
                return null;
            return User;
        }

        public User InsertUser(User User)
        {
            User _user = context.Users.SingleOrDefault(e => e.PhoneNumber == User.PhoneNumber);
            if (_user == null)
            {
                Guid g = Guid.NewGuid();
                User.UserId = g.ToString();
                context.Users.Add(User);
                if (context.SaveChanges() > 0)
                    return User;
                return null;
            }
            return null;
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
