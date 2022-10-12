namespace DesignPatterns.Behavioral.Strategy.Strategy;

/// <summary>
/// A Concrete Strategy class
/// </summary>
public class Grilling : ICookingStrategy
{
    public void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by grilling it.");
    }
}

