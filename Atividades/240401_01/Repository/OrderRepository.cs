using System;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class OrderRepository
    {
        public void Save(Order order)
        {
            DataSet.Orders.Add(order);
        }

        public Order? Retrieve(int id)
        {
            foreach (var o in DataSet.Orders)
                if (o.OrderId == id)
                    return o;
            
            return null;
        }
    }
}