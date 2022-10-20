using DesignPatterns_101.Behavioral.Visitor.Client;

namespace DesignPatterns_101.Behavioral.Visitor;

/// <summary>
/// The 'Visitor' interface
/// </summary>
public interface IVisitor
{
    void Visit(Element element);
}
