public class Product
{
    private string _name;
    private string _ID;
    private int _quantity;
    private double _price;
    public Product(){
    
    }

    public double TotalPrice(){
        return _price * _quantity;
    }
    
    // GET AND SET

    public void SetProductName(){
       Console.WriteLine("Insert Product name: ");
        _name = Console.ReadLine();
    }

    public string GetProductName(){
        return _name;
    }
    public void SetProductID(){
        Console.WriteLine("Insert the ID");
        _ID = Console.ReadLine();
    }
    public string GetProductID(){
        return _ID;
    }

    public double GetPrice(){
        return _price;
    }
    public void SetPrice(){
        Console.WriteLine("Inser the Price: ");
        _price = float.Parse(Console.ReadLine());
    }

    public void SetQuantity()
    {
        Console.WriteLine("Inset the quantity of the product: ");
        _quantity = int.Parse(Console.ReadLine());
    }

    public int GetQuantity()
    {
        return _quantity;
    }



}