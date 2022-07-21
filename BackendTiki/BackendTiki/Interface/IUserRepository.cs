using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IUserRepository : IDisposable
    {
        public List<User> GetUsers();


        public User GetUserByID(string id);



        public User InsertUser(User User);


        public void Save();
    }
}
