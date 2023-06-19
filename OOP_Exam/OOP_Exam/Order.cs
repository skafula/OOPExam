using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class Order
    {
        private double _totalAmount;
        public Customer Customer { get; set; }
        public string Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalAmount
        {
            get; set;
        }
        public Order (string date, Customer customer, List<OrderItem> orderItems)
        {
            Date = date;
            Customer = customer;
            OrderItems = orderItems;
            foreach (var item in OrderItems)
            {
                TotalAmount += item.TotalPrice;
            }
        }
        public override string ToString()
        {
            return $"({Date}): {TotalAmount}\n  Customer: {Customer.Name}\n  Item(s):\n    {GetOrderItemList()}";
        }
        public string GetOrderItemList()
        {
            string result = "";
            foreach (var item in OrderItems)
            {
                result += item.Product.Name + " x" + item.Quantity + " = " + item.TotalPrice + "\n    ";
            }
            return result;
        }
    }
}
