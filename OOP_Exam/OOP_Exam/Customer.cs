using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class Customer
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public List<Order> OrderHistory { get; set; }
        public Customer(string name, string email)
        {
            Email = email;
            Name = name;
        }
        public void AddOrder(Order order)
        {
            OrderHistory.Add(order);
        }
    }
}
