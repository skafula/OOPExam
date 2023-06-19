using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class OrderItem
    {
        private double _totalPrice;
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice 
        {
            get; set; 
        }
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            TotalPrice = Product.Price * Quantity;
        }
    }
}
