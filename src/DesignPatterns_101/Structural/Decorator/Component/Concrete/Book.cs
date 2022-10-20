using DesignPatterns_101.Structural.Decorator.Component.Abstract;

namespace DesignPatterns_101.Structural.Decorator.Component.Concrete;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Book : LibraryItem
{
    private string _author;
    private string _title;
    // Constructor

    public Book(string author, string title, int numCopies)
    {
        _author = author;
        _title = title;
        this.NumCopies = numCopies;
    }
    public override void Display()
    {
        Console.WriteLine("\nBook ------ ");
        Console.WriteLine(" Author: {0}", _author);
        Console.WriteLine(" Title: {0}", _title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
    }
}