using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface ISupplierRepository : IDisposable
    {
        public List<Supplier> GetSuppliers();
     

        public Supplier GetSupplierByID(string id);



        public void InsertSupplier(Supplier Supplier);


        public void Save();
        
    }
}
