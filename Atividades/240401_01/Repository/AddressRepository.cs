using System;
using _240401_01.Models;
using _240401_01.Data;

namespace _240401_01.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            DataSet.Addresses.Add(address);
        }

        public Address? Retrieve(int id)
        {
            foreach (var a in DataSet.Addresses)
                if (a.Id == id)
                    return a;
            
            return null;
        }
    }
}