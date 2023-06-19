using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class ClothingProduct : Product
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public ClothingProduct(string color, string size, string name, string date, string description, double price, int quantity) 
                                : base(name, date, description, price, quantity)
        {
            Color = color;
            Size = size;
        }
    }
}
