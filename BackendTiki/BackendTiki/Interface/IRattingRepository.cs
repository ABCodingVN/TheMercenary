using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IRattingRepository : IDisposable
    {
        List<Ratting> GetRattings();

        Ratting GetRattingByID(string id);

        void InsertRatting(Ratting Ratting);

        void Save();
        
    }
}
