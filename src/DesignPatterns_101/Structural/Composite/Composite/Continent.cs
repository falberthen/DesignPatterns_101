using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

/// <summary>
/// Composite class, root node
/// </summary>
public class Continent : Boundary
{
    public Continent(string name): base(name)
    {
        Name = name;
    }
}
