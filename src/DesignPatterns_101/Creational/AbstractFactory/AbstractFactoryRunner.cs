using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Factories.Concrete;

namespace DesignPatterns.Creational.AbstractFactory;

/// <summary>
/// This class was designed to demonstrate 
/// the usage of AbstractFactory pattern
/// </summary>
public class AbstractFactoryRunner
{
    public static void Execute()
    {
        Console.WriteLine("\nWho are you? (A)dult or (C)hild?");
        char option = Console.ReadKey().KeyChar;

        RecipeFactory factory = Char.ToUpper(option) switch
        {
            'A' => new AdultCuisineFactory(),
            'C' => new KidCuisineFactory(),
            _ => throw new ArgumentException("Invalid option."),
        };

        var sandwich = factory.CreateSandwich();
        var dessert = factory.CreateDessert();

        Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
        Console.WriteLine("Dessert: " + dessert.GetType().Name);
        Console.ReadKey();
    }
}