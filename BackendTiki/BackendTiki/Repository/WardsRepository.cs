
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
    public class WardsRepository : IWardsRepository, IDisposable
    {
        private Context context;

        public WardsRepository(Context context)
        {
            this.context = context;
        }

        public List<Wards> GetWards()
        {
            return context.Wards.ToList();
        }

        public Wards GetWardsByID(string id)
        {   Wards Wards = context.Wards.Find(id);
            if(Wards == null)
                return null;
            return Wards;
        }

        public void InsertWards(Wards Wards)
        {
            context.Wards.Add(Wards);
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
