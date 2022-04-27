public class menuexample
{
    private string _name;
    public string Name
    {
        get{ return _name;}
        set{ _name = value;}
    }
    private int _mousePrice;
    private int _keyboardPrice;
    private int _phonePrice;
    private int _laptopPrice;
    private int _total;
    public int Totalprice
    {
        get {return _total;}
        set {_total = value;}
    }

    public menuexample()
    {
        _name = "Robert";
        _mousePrice = 10;
        _keyboardPrice = 99;
        _phonePrice = 1000;
        _laptopPrice = 2000;
    }
    //This method will greet user
    public void Greetuser()
    {
        Console.Clear();
        Console.WriteLine("Hello " + _name + "! What can I do for you?");
        Console.WriteLine("1. Buy an item ");
        Console.WriteLine("2. Checkout");
    }

    public void Buyitems()
    {
        Console.WriteLine("1 - mouse $" + _mousePrice);
        Console.WriteLine("2 - keyboard $" + _keyboardPrice);
        Console.WriteLine("3 - phone $" + _phonePrice);
        Console.WriteLine("4 - laptop $" + _laptopPrice);
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            _total += _mousePrice;
        }
        else if(answer == "2")
        {
            _total += _keyboardPrice;
        }
        else if(answer == "3")
        {
            _total += _phonePrice;
        }
        else if( answer == "4")
        {
            _total += _laptopPrice;
        }
        Console.WriteLine("Your current total is: " + _total);
    }
}