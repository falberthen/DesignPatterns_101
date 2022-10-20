using DesignPatterns_101.Structural.Decorator.Component.Concrete;
using DesignPatterns_101.Structural.Decorator.Decorator.Concrete;

namespace DesignPatterns.Structural.Decorator;

public class DecoratorRunner
{
    public static void Execute()
    {
        // Create book
        Book book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();

        // Create video
        Video video = new Video("Spielberg", "Jaws", 23, 92);
        video.Display();

        // Make video borrowable, then borrow and display
        Console.WriteLine("\nMaking video borrowable:");
        Borrowable borrowvideo = new Borrowable(video);
        borrowvideo.BorrowItem("Customer #1");
        borrowvideo.BorrowItem("Customer #2");
        borrowvideo.Display();

        // Wait for user
        Console.ReadKey();
    }
}


//https://www.dofactory.com/net/decorator-design-pattern