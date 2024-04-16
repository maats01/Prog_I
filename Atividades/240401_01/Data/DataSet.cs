using System;
using _240401_01.Models;

namespace _240401_01.Data
{
    public class DataSet
    {
        public static List<Address> Addresses { get; set; }
        public static List<Customer> Customers { get; set; }
        public static List<Product> Products { get; set; }
        public static List<Order> Orders { get; set; }
    }
}