using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategy;

namespace DesignPatterns.Behavioral.Strategy;

public class StrategyRunner
{
    public static void Execute()
    {
        Console.WriteLine("What food would you like to cook?\n");
        var food = Console.ReadLine();

        Console.WriteLine("\nWhat cooking strategy would you like to use?\n");
        Console.WriteLine("1 - Grilling");
        Console.WriteLine("2 - Oven baking");
        Console.WriteLine("3 - Deep frying");

        int choice = int.Parse(Console.ReadKey().KeyChar.ToString());

        CookingMethod cookingMethod = choice switch
        {
            1 => new CookingMethod(new Grilling()),
            2 => new CookingMethod(new OvenBaking()),
            3 => new CookingMethod(new DeepFrying()),
            _ => throw new ArgumentException("Invalid option."),
        };

        cookingMethod.SetFood(food);
        cookingMethod.Cook();

        Console.ReadKey();
    }
}
