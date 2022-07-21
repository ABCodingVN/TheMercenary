using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IWardsRepository : IDisposable
    {
        public List<Wards> GetWards();


        public Wards GetWardsByID(string id);



        public void InsertWards(Wards Wards);


        public void Save();
    }
}
