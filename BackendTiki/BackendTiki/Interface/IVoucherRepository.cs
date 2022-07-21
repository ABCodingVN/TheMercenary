using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IVoucherRepository : IDisposable
    {
        public List<Voucher> GetVouchers();


        public Voucher GetVoucherByID(string id);



        public void InsertVoucher(Voucher Voucher);


        public void Save();
    }
}
