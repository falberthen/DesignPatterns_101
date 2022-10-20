using DesignPatterns_101.Structural.Decorator.Component.Abstract;

namespace DesignPatterns_101.Structural.Decorator.Component.Concrete;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class Video : LibraryItem
{
    private string _director;
    private string _title;
    private int _playTime;

    // Constructor
    public Video(string director, string title, int numCopies, int playTime)
    {
        _director = director;
        _title = title;
        _playTime = playTime;
        NumCopies = numCopies;
    }

    public override void Display()
    {
        Console.WriteLine("\nVideo ----- ");
        Console.WriteLine(" Director: {0}", _director);
        Console.WriteLine(" Title: {0}", _title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
        Console.WriteLine(" Playtime: {0}\n", _playTime);
    }
}