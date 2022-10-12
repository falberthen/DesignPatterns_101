namespace DesignPatterns.Behavioral.Strategy.Strategy;

/// <summary>
/// A Concrete Strategy class
/// </summary>
class OvenBaking : ICookingStrategy
{
    public void Cook(string food)
    {
        Console.WriteLine("\nCooking " + food + " by oven baking it.");
    }
}
