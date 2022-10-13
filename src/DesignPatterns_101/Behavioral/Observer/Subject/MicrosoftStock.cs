// <summary>
/// The 'ConcreteSubject' class
/// </summary>
/// 
namespace DesignPatterns.Behavioral.Observer.Subject;

public class MicrosoftStock : Stock
{
    public MicrosoftStock(string symbol, double price)
      : base(symbol, price) {}
}