namespace DesignPatterns.Creational.FactoryMethod;

public class Connection
{
    public string ConnectionString { get; set; }
    public bool IsOpen { get; set; }

    public Connection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public void ExecuteCommand(string command)
    {
        Console.WriteLine($"Executing command: {command}");
    }

    public void Open()
    {
        IsOpen = true;
        Console.WriteLine("Open connection");
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("Closed connection");
    }
}
