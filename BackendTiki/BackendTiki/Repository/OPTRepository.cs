
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
    public class OTPRepository : IOTPRepository, IDisposable
    {
        private Context context;

        public OTPRepository(Context context)
        {
            this.context = context;
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

        public int getOPT(string phone)
        {
            User user = context.Users.FirstOrDefault(u => u.PhoneNumber.Equals(phone));

            if (user == null) return -1;

            Random random = new Random();
            int OTPNumber = random.Next(100000, 999999);


            return OTPNumber;
        }
    }
}
