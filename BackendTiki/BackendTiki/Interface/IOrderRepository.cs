using System;
using System.Collections.Generic;
using BackendTiki.Models;

namespace BackendTiki.Interface
{
    public interface IOrderRepository : IDisposable
    {
        List<Order> GetOrders();
        Order GetOrderByID(string OrderId);
        void InsertOrder(Order Order);

        void Save();
    }
}
