using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public class Store
    {
        public List<Product> Products = new List<Product>();
        public string Location { get; set; }
        public string Name { get; set; }
        public List<Order> Orders = new List<Order>();
        public Store(string location, string name)
        {
            Location = location;
            Name = name;
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        // 2 overloads
        public List<Order> GetOrders()
        {
            var allOrders = new List<Order>();
            foreach (Order order in Orders)
            {
                allOrders.Add(order);
            }
            return allOrders;
        }
        public List<Order> GetOrders(Customer customer)
        {
            var allOrdersByName = new List<Order>();
            foreach (Order order in Orders)
            {
                if (customer.Name == order.Customer.Name)
                {
                    allOrdersByName.Add(order);
                }
            }
            return allOrdersByName;
        }
        public void RemoveProduct(Product product)
        {
            foreach (Product item in Products)
            {
                if (product.Name == item.Name)
                {
                    Products.Remove(item);
                }
            }
        }
        public void SearchProducts(string name)
        {
            foreach (Product product in Products)
            {
                if (product.Name == name)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public List<Product> SearchProductsByCategory(string category)
        {
            List<Product> products = new List<Product>();
            foreach(Product product in Products)
            {
                switch (category)
                {
                    case "ClothingProduct":
                        if (product is ClothingProduct) 
                        { 
                            products.Add((ClothingProduct)product);
                        }
                        break;
                    case "ElevtronicsProduct":
                        if (product is ElectronicsProduct)
                        {
                            products.Add((ElectronicsProduct)product);
                        }
                        break;
                    default: 
                        break;
                }
            }
            return products;
        }
        public override string ToString()
        {
            return $"Név: {Name} \tHely: {Location}\nTermékkínálat: {string.Join(" ", Products)}";
        }
    }
}
