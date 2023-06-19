using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class Product
    {
        public Customer Customer { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalAmount 
        { 
            get { return Price * Quantity; }
        }
        public Product(string name, string date, string description, double price, int quantity)
        {
            Name = name;
            Date = date;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name} x{Quantity} - {Price}";
        }
    }
}
