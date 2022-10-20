using DesignPatterns_101.Behavioral.Visitor.Client;
using DesignPatterns_101.Behavioral.Visitor.ConcreteVisitors;

namespace DesignPatterns_101.Behavioral.Visitor;

public class VisitorRunner
{
    public static void Execute()
    {
        // Setup employee collection
        Employees employees = new Employees();

        employees.Attach(new Clerk());
        employees.Attach(new Director());
        employees.Attach(new President());

        // Employees are 'visited'
        employees.Visit(new IncomeVisitor());
        employees.Visit(new VacationVisitor());

        // Wait for user
        Console.ReadKey();
    }
}


//https://www.dofactory.com/net/visitor-design-pattern