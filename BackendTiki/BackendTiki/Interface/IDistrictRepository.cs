using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IDistrictRepository : IDisposable
    {
         List<District> GetDistricts();

         District GetById(string id);

         void Save();
       
    }
}
