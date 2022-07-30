using System;
using System.Collections.Generic;
using BackendTiki.Dto;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface ILoginRepository : IDisposable
    {
        User LoginByPhoneNumber(LoginDTO account);
        void Save();
    }
    
}
