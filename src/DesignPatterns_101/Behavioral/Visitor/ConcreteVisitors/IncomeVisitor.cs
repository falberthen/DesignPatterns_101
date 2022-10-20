using DesignPatterns_101.Behavioral.Visitor.Client;

namespace DesignPatterns_101.Behavioral.Visitor.ConcreteVisitors;

public class IncomeVisitor : IVisitor
{
    public void Visit(Element element)
    {
        Employee employee = element as Employee;
        var oldIncome = employee.Income;

        // Provide 10% pay raise
        employee.Income *= 1.10;

        Console.WriteLine($"{employee.GetType().Name} {employee.Name} got a raise from {oldIncome:C} to {employee.Income:C}");
    }
}