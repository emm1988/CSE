using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address address1 = new Address("123 Palm Dr", "Houston", "TX", "USA");
        Address address2 = new Address("98 Santiago Segura St", "Madrid", "MA", "Spain");

        // Customers
        Customer customer1 = new Customer("Willy Wonka", address1);
        Customer customer2 = new Customer("Charlie Brown", address2);

        // Products
        Product product1 = new Product("Chocolate Bar", "A001", 5.95, 9);  
        Product product2 = new Product("Candy", "A002", 2.60, 5);     
        Product product3 = new Product("Microphone", "A003", 15.99, 2); 
        Product product4 = new Product("Camera", "A004", 55.99, 1); 

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Order information
        Console.WriteLine(" ORDER 1 ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine(" ORDER 2 ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}