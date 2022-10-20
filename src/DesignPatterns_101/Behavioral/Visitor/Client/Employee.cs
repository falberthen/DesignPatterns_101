namespace DesignPatterns_101.Behavioral.Visitor.Client;

/// <summary>
/// The 'ConcreteElement' class
/// </summary>
public class Employee : Element
{
    private string _name;
    private double _income;
    private int _vacationDays;

    // Constructor
    public Employee(string name, double income,
        int vacationDays)
    {
        _name = name;
        _income = income;
        _vacationDays = vacationDays;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Income
    {
        get { return _income; }
        set { _income = value; }
    }

    public int VacationDays
    {
        get { return _vacationDays; }
        set { _vacationDays = value; }
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
