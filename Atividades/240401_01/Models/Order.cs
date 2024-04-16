using System;

namespace _240401_01.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string? ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public bool Validate()
        {
            return true;
        }
    }
}