namespace DesignPatterns.Behavioral.Strategy.Strategy;

/// <summary>
/// Defined an interface common to all supported strategy algorithms.
/// </summary>
public interface ICookingStrategy
{
    public void Cook(string food);
}
