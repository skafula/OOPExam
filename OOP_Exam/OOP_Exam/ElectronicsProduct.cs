using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class ElectronicsProduct : Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public ElectronicsProduct(string brand, string model, string name, string date, string description, double price, int quantity)
            : base(name, date, description, price, quantity)
        {
            Brand = brand;
            Model = model;
        }
    }
}
