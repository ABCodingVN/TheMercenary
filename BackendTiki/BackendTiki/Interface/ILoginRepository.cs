using System;
using System.Collections.Generic;
using BackendTiki.Dto;

namespace BackendTiki.Interface
{
    public interface ILoginRepository : IDisposable
    {
        string LoginByPhoneNumber(LoginDTO account);
        void Save();
    }
    
}
