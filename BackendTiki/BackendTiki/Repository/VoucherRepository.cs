
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
    public class VoucherRepository : IVoucherRepository, IDisposable
    {
        private Context context;

        public VoucherRepository(Context context)
        {
            this.context = context;
        }

        public List<Voucher> GetVouchers()
        {
            return context.Vouchers.ToList();
        }

        public Voucher GetVoucherByID(string id)
        {   Voucher Voucher = context.Vouchers.Find(id);
            if(Voucher == null)
                return null;
            return Voucher;
        }

        public void InsertVoucher(Voucher Voucher)
        {
            context.Vouchers.Add(Voucher);
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
