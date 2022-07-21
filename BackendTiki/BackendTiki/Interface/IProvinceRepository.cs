using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IProvinceRepository : IDisposable
    {
        List<Province> GetProvices();
        Province GetProviceByID(string ProviceId);
        void InsertProvice(Province Provice);

        void Save();
    }
}
