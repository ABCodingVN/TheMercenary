
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
    public class SupplierRepository : ISupplierRepository, IDisposable
    {
        private Context context;

        public SupplierRepository(Context context)
        {
            this.context = context;
        }

        public List<Supplier> GetSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public Supplier GetSupplierByID(string id)
        {   Supplier Supplier = context.Suppliers.SingleOrDefault(e=>e.SupplierId==id);
            if(Supplier == null)
                return null;
            return Supplier;
        }

        public void InsertSupplier(Supplier Supplier)
        {
            context.Suppliers.Add(Supplier);
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
