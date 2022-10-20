namespace DesignPatterns_101.Behavioral.Visitor.Client;

/// <summary>
/// The 'ObjectStructure' class
/// </summary>
public class Employees
{
    private List<Employee> _employees = new();

    public void Attach(Employee employee)
    {
        _employees.Add(employee);
    }

    public void Detach(Employee employee)
    {
        _employees.Remove(employee);
    }

    public void Visit(IVisitor visitor)
    {
        foreach (Employee employee in _employees)
        {
            employee.Accept(visitor);
        }

        Console.WriteLine();
    }
}
