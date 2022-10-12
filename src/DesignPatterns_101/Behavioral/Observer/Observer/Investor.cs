using DesignPatterns.Behavioral.Observer.Subject;

/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
namespace DesignPatterns.Behavioral.Observer.Observer;

public class Investor : IInvestor
{
    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }

    public Investor(string name)
    {
        Name = name;
    }

    public Stock Stock
    {
        get { return _stock; }
        set { _stock = value; }
    }

    public void Update(Stock stock)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Notified {Name} that {stock.Symbol} stock price changed to {stock.Price}");
    }

    private string _name;
    private Stock _stock;
}