using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Repository;
using _240401_01.Models;

namespace _240401_01.Controllers
{
    public class AddressController
    {
        private AddressRepository addressRepository;

        public AddressController()
        {
            this.addressRepository = new AddressRepository();
        }

        public Address Insert(Address address)
        {
            this.addressRepository.Insert(address);
            return address;
        }

        public void Delete(Customer customer, Address address)
        {
            addressRepository.Delete(customer, address);
        }

        public Address Get(int id)
        {
            return addressRepository.Read(id);
        }

        public List<Address> Get()
        {
            return addressRepository.Read();
        }

        
    }
}