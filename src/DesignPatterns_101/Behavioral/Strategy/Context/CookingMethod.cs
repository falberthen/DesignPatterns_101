using DesignPatterns.Behavioral.Strategy.Strategy;

namespace DesignPatterns.Behavioral.Strategy.Context;

/// <summary>
/// The Context class, which maintains a reference to the chosen Strategy.
/// </summary>
public class CookingMethod
{
    private string _food;
    private ICookingStrategy _cookingStragegy;

    public CookingMethod(ICookingStrategy cookingStragegy)
    {
        _cookingStragegy = cookingStragegy;
    }

    public void SetFood(string name)
    {
        if (string.Empty == name)
            name = "dish";

        _food = name;
    }

    public void Cook()
    {
        _cookingStragegy.Cook(_food);
        Console.WriteLine();
    }
}