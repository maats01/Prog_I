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

        public void Insert(Customer customer, bool autoGenerateId)
        {
            if(autoGenerateId)
                customer.CustomerId = GetNextId();
            
            DataSet.Customers.Add(customer);
        }

        public Customer Retrieve(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerId == id)                
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

        public bool ImportFromTxt(string line, string delimiter)
        {
            if(string.IsNullOrWhiteSpace(line))
                return false;
    
            string[] data = line.Split(delimiter);
            
            if(data.Count() < 1)
                return false;

            Customer c = new Customer{
                CustomerId = Convert.ToInt32((data[0] == null ? 0 : data[0])),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = (data[2] ?? string.Empty)
            };

            Insert(c, false);
            
            return true;
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