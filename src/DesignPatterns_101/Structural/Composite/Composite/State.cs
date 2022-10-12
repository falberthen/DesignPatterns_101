using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

/// <summary>
/// Composite class
/// </summary>
public class State : Boundary, IBoundary
{
    public State(string name) : base(name)
    {
        Name = name;
    }
}
