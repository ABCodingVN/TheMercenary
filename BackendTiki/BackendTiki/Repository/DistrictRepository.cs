
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
    public class DistrictRepository : IDistrictRepository, IDisposable
    {
        private Context context;

        public DistrictRepository(Context context)
        {
            this.context = context;
        }

        public List<District> GetDistricts()
        {
            return context.District.ToList();
        }
        public District GetById(string id)
        {
            return context.District.SingleOrDefault(e => e.DistrictId == id);
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
