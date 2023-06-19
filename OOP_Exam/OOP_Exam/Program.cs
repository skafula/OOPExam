using OOP_Exam;
using System.Collections.Specialized;

public class Program
{
    static List<Customer> _customers = new List<Customer>();
    static List<Store> _store = new List<Store>();

    static void CreateOrders()
    {
        List<OrderItem> orderList1 = new List<OrderItem>();
        orderList1.Add(new OrderItem(2, _store[0].Products[1]));
        orderList1.Add(new OrderItem(2, _store[0].Products[3]));
        Order order1 = new Order("07.03.2023", _customers[0], orderList1);
        _store[0].Orders.Add(order1);

        List<OrderItem> orderList2 = new List<OrderItem>();
        orderList2.Add(new OrderItem(1, _store[0].Products[0]));
        orderList2.Add(new OrderItem(1, _store[0].Products[2]));
        Order order2 = new Order("07.05.2023", _customers[0], orderList2);
        _store[0].Orders.Add(order2);
    }

    #region Display
    static void DisplayOrders()
    {
        int count = 1;
        Console.WriteLine("Orders in Legend Store: \n");
        foreach (var item in _store[0].Orders) 
        {
            Console.WriteLine($"Order #{count} {item.ToString()}");
            count++;
        }
    }
    static void DisplayStock()
    {
        Console.WriteLine("Products in Legend Store: \n");
        foreach (var item in _store[0].Products) 
        {
            Console.WriteLine(item.ToString());
        }
    }
    #endregion

    #region Init
    static void InitCustomer()
    {
        AddCustomer("Kovács András", "kovacs@gmail.com");
        AddCustomer("Szabó Katalin", "szabo@freemail.hu");
    }
    static void InitShop()
    {
        _store.Add(new Store("Budapest", "Legend Store"));
    }
    static void InitStock()
    {
        AddClothingProduct("Zöld", "M", "Nike póló", "03.05.2022", "Zöld színű pamut póló", 4000, 3);
        AddClothingProduct("Kék", "L", "Adidas póló", "02.04.2021", "Kék színű pamut póló", 3000, 2);

        AddElectronicsProduct("iPhone", "SE", "iPhone SE", "01.01.2020", "64GB Szürke iPhone SE", 200000, 5);
        AddElectronicsProduct("Samsung", "Galaxy", "Samsung Galaxy", "01.03.2019", "128GB Samsung Galaxy", 150000, 2);
    }
    #endregion

    #region AddMethods
    static void AddCustomer(string name, string email)
    {
        _customers.Add(new Customer(name, email));
    }
    static void AddClothingProduct(string color, string size, string name, string date, string description, double price, int quantity)
    {
        _store[0].Products.Add(new ClothingProduct(color, size, name, date, description, price, quantity));
    }
    static void AddElectronicsProduct(string brand, string model, string name, string date, string description, double price, int quantity)
    {
        _store[0].Products.Add(new ElectronicsProduct(brand, model, name, date, description, price, quantity));
    }
    #endregion

    private static void Main(string[] args)
    {
        InitShop();
        InitCustomer();
        InitStock();
        CreateOrders();
        DisplayStock();
        Console.WriteLine("\n");
        DisplayOrders();
    }
}