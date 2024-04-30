using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Repository;

namespace _240401_01.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public void Insert(Customer customer)
        {
            customerRepository.Create(customer);
        }

        public Customer Get(int id)
        {
            return customerRepository.Read(id);
        }

        public List<Customer> Get()
        {
            return customerRepository.Read();
        }
    }
}