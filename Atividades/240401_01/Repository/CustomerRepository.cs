using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class CustomerRepository
    {                
        public void Create(Customer customer)
        {
            customer.CustomerId = GetNextId();
            DataSet.Customers.Add(customer);
        }
        
        public Customer Read(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )                
                    return c;                
            }

            return null;
        }

        public List<Customer> Read()
        {
            return DataSet.Customers;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach (var a in DataSet.Customers)
            {
                if (a.CustomerId > n)
                    n = a.CustomerId;
            }

            return n++;
        }
    }
}