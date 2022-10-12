// <summary>
/// The 'ConcreteSubject' class
/// </summary>
namespace DesignPatterns.Behavioral.Observer.Subject;

public class AmazonStock : Stock
{
    public AmazonStock(string symbol, double price)
      : base(symbol, price) {}
}
