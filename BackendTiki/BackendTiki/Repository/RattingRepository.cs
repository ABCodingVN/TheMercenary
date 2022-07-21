
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
    public class RattingRepository : IRattingRepository, IDisposable
    {
        private Context context;

        public RattingRepository(Context context)
        {
            this.context = context;
        }

        public List<Ratting> GetRattings()
        {
            return context.Rattings.ToList();
        }

        public Ratting GetRattingByID(string id)
        {   Ratting Ratting = context.Rattings.Find(id);
            if(Ratting == null)
                return null;
            return Ratting;
        }

        public void InsertRatting(Ratting Ratting)
        {
            context.Rattings.Add(Ratting);
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
