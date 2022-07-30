using System;
using System.Collections.Generic;
using BackendTiki.Models;
using BackendTiki.Dto;
namespace BackendTiki.Interface
{
    public interface IUserRepository : IDisposable
    {
        public List<User> GetUsers();


        public User GetUserByID(string id);



        public User InsertUser(RegisterDTO User);


        public void Save();
    }
}
