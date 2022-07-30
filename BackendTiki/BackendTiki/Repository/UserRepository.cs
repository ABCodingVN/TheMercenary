
using BackendTiki.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BackendTiki.Dto;
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

        public User InsertUser(RegisterDTO User)
        {
            try
            {
                User _user = context.Users.FirstOrDefault(e => e.PhoneNumber == User.PhoneNumber);

                if (_user == null)
                {
                    User user = new User();
                    Guid g = Guid.NewGuid();
                    user.UserId = g.ToString();
                    user.Name = User.Name;
                    user.Address = User.Address;
                    user.PhoneNumber = User.PhoneNumber;
                    user.Gmail = User.Gmail;
                    user.WardsID = User.WardsID;
                    user.Password = User.Password;
                    context.Users.Add(user);
                    if (context.SaveChanges() > 0)
                        return user;
                   
                }
                return null;
            }
            catch
            {
                return null;
            }
           
          
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
