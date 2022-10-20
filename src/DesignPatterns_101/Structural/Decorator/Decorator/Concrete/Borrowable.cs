using DesignPatterns_101.Structural.Decorator.Component.Abstract;
using DesignPatterns_101.Structural.Decorator.Decorator.Abstract;

namespace DesignPatterns_101.Structural.Decorator.Decorator.Concrete;

/// <summary>
/// The 'ConcreteDecoratorA' class
/// </summary>
public class Borrowable : AbstractDecorator
{
    protected readonly List<string> borrowers = new List<string>();

    public Borrowable(LibraryItem libraryItem)
        : base(libraryItem)
    {
    }

    public void BorrowItem(string name)
    {
        borrowers.Add(name);
        _libraryItem.NumCopies--;
    }

    public void ReturnItem(string name)
    {
        borrowers.Remove(name);
        _libraryItem.NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        foreach (string borrower in borrowers)
        {
            Console.WriteLine(" borrower: " + borrower);
        }
    }
}