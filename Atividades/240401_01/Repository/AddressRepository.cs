using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class AddressRepository
    {
        public void Create(Address address)
        {
            address.Id = GetNextId();
            DataSet.Addresses.Add(address);
        }

        public Address Read(int id)
        {            
            foreach(var c in DataSet.Addresses)
            {
                if( c.Id == id )                
                    return c;                
            }

            return null;
        }

        public List<Address> Read()
        {
            return DataSet.Addresses;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach (var a in DataSet.Addresses)
            {
                if (a.Id > n)
                    n = a.Id;
            }

            return n++;
        }
    }
}