using System;

namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> Addresses { get; set; }

        public Customer()
        {
            
        }

        public Customer(int id)
        {
            CustomerId = id;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            return isValid;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
    }
}