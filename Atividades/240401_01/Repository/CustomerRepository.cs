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
        public void Insert(Customer customer)
        {
            customer.CustomerId = GetNextId();
            DataSet.Customers.Add(customer);
        }
        
        public void Delete(int id)
        {
            DataSet.Customers.Remove(Retrieve(id));
        }

        public Customer Retrieve(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )                
                    return c;                
            }

            return null;
        }

        public List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }

        public List<Customer> RetrieveByName(string name)
        {
            List<Customer> retorno = new List<Customer>();
            foreach (var c in DataSet.Customers)
            {
                if (c.Name.Contains(name))
                    retorno.Add(c);
            }

            return retorno;
        }
    
        private int GetNextId()
        {
            int n = 0;
            foreach (var a in DataSet.Customers)
            {
                if (a.CustomerId > n)
                    n = a.CustomerId;
            }

            return ++n;
        }
    }
}