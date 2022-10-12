using DesignPatterns.Creational.FactoryMethod.Product.Abstract;

namespace DesignPatterns.Creational.FactoryMethod.Product.Concrete;

/// <summary>
/// Concrete Product
/// </summary>
public class OracleDbConnector : DbConnector
{
    public OracleDbConnector(string connectionString) 
        : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Connecting to Oracle...");
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}