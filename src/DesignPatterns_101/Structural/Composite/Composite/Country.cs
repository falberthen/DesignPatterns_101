using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

/// <summary>
/// Composite class
/// </summary>
public class Country : Boundary
{
    public Country(string name): base(name)
    {
        Name = name;
    }
}
