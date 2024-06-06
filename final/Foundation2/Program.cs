using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1
        Customer customer1 = new();
        Product customer1Product1 = new();
        Product customer1Product2 = new();
        Product customer1Product3 = new();
        Order order1 = new();
        customer1.SetCustomerName();
        customer1.SetCustomerAddress("6ta Street, #5", "Chalatenango", "Chalatenango", "El Salvador");
        order1.AddCustomer(customer1);
        customer1Product1.SetProductName();
        customer1Product1.SetProductID();
        customer1Product1.SetPrice();
        customer1Product1.SetQuantity();
        order1.AddProduct(customer1Product1);
        Console.WriteLine("");
        customer1Product2.SetProductName();
        customer1Product2.SetPrice();
        customer1Product2.SetQuantity();
        order1.AddProduct(customer1Product2);
        Console.WriteLine("");
        customer1Product3.SetProductName();
        customer1Product3.SetPrice();
        customer1Product3.SetQuantity();
        order1.AddProduct(customer1Product3);
        Console.WriteLine("");
        order1.DisplayShippingInfo();


        // Customer 2
        Customer customer2 = new();
        Product customer2Product1 = new();
        Product customer2Product2 = new();
        Product customer2Product3 = new();
        Order order2 = new();
        customer2.SetCustomerName();
        customer2.SetCustomerAddress("177 Ave, Main Street", "New York", "New York", "USA");
        order2.AddCustomer(customer2);
        customer2Product1.SetProductName();
        customer2Product1.SetPrice();
        customer2Product1.SetQuantity();
        order2.AddProduct(customer2Product1);
        Console.WriteLine("");
        customer2Product2.SetProductName();
        customer2Product2.SetPrice();
        customer2Product2.SetQuantity();
        order2.AddProduct(customer2Product2);
        Console.WriteLine("");
        customer2Product3.SetProductName();
        customer2Product3.SetPrice();
        customer2Product3.SetQuantity();
        order2.AddProduct(customer2Product3);
        Console.WriteLine("");
        order2.DisplayShippingInfo();

    }
    
}