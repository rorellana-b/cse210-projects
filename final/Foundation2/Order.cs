public class Order
{
    private List<Product> _products = new();
    private List<Customer> _customers = new();
    private int _inUSA = 10;
    private int _otherCountry = 20;
    private int _shippingCost;
    private double _totalPrice;

    public Order()
    {

    }

    public void GetShippinglabel()
    {
        foreach (Customer customer in _customers)
        {
            Address theAddress = customer.GetAddress();
            Console.WriteLine("\nShipping label:");
            Console.WriteLine($"{theAddress.DisplayAddressInfo()}");
            _shippingCost = customer.IsCustomerInUSA() ? _inUSA : _otherCountry;
        }
    }

    public int GetShippingCost()
    {
        return _shippingCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("\nPacking label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetProductName()} - Product ID: {product.GetProductID()}");
        }
    }

    public double CalculateTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.TotalPrice();
        }

        return _totalPrice + GetShippingCost();
    }

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddProduct(Product item)
    {
        _products.Add(item);
    }

    public void DisplayShippingInfo()
    {
        Console.WriteLine("BILLING INFORMATION");
        GetPackingLabel();
        GetShippinglabel();
        Console.WriteLine($"\nYour total cost is ${Math.Round(CalculateTotalCost(),2)}\n");
        Console.WriteLine("-------------------------------");
    }
    
}