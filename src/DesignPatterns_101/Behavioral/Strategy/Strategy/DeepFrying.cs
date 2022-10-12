namespace DesignPatterns.Behavioral.Strategy.Strategy;

/// <summary>
/// A Concrete Strategy class
/// </summary>
public class DeepFrying : ICookingStrategy
{
    public void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by deep frying it");
    }
}
