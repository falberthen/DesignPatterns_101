using DesignPatterns_101.Behavioral.Visitor.Client;

namespace DesignPatterns_101.Behavioral.Visitor.ConcreteVisitors;

// <summary>
/// A 'ConcreteVisitor' class
/// </summary>
public class VacationVisitor : IVisitor
{
    public void Visit(Element element)
    {
        Employee employee = element as Employee;
        var oldVacationDays = employee.VacationDays;

        // Provide 3 extra vacation days
        employee.VacationDays += 3;

        Console.WriteLine($"{employee.GetType().Name} {employee.Name} had vacation days increased from {oldVacationDays} to {employee.VacationDays}");
    }
}
