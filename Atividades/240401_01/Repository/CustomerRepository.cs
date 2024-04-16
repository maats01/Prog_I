using System;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            DataSet.Customers.Add(customer);
        }

        public Customer? Retrieve(int id)
        {
            foreach (var c in DataSet.Customers)
                if (c.CustomerId == id)
                    return c;

            return null;
        }
    }
}