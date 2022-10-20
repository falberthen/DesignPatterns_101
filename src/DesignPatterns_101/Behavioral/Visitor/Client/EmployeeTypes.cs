namespace DesignPatterns_101.Behavioral.Visitor.Client;

// Three employee types
public class Clerk : Employee
{
    // Constructor
    public Clerk(): base("Kevin", 25000.0, 14) {}
}
public class Director : Employee
{
    // Constructor
    public Director() : base("Elly", 35000.0, 16) {}
}
public class President : Employee
{
    // Constructor
    public President() : base("Eric", 45000.0, 21) {}
}
