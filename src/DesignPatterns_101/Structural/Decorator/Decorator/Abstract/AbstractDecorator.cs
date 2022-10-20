using DesignPatterns_101.Structural.Decorator.Component.Abstract;

namespace DesignPatterns_101.Structural.Decorator.Decorator.Abstract;

/// <summary>
/// The 'Decorator' abstract class
/// </summary>
public abstract class AbstractDecorator : LibraryItem
{
    protected LibraryItem _libraryItem;

    // Constructor
    public AbstractDecorator(LibraryItem libraryItem)
    {
        _libraryItem = libraryItem;
    }

    public override void Display()
    {
        _libraryItem.Display();
    }
}