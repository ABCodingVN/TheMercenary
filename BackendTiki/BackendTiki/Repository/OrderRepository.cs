
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
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private Context context;

        public OrderRepository(Context context)
        {
            this.context = context;
        }

        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetOrderByID(string id)
        {   Order Order = context.Orders.Find(id);
            if(Order == null)
                return null;
            return Order;
        }

        public void InsertOrder(Order Order)
        {
            context.Orders.Add(Order);
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
