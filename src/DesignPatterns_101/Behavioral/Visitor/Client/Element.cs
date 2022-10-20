namespace DesignPatterns_101.Behavioral.Visitor.Client;

/// <summary>
/// The 'Element' abstract class
/// </summary>
public abstract class Element
{
    public abstract void Accept(IVisitor visitor);
}

