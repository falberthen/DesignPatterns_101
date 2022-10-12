using DesignPatterns.Creational.FactoryMethod.Product.Abstract;

namespace DesignPatterns.Creational.FactoryMethod.Product.Concrete;

/// <summary>
/// Concrete Product
/// </summary>
public class PostgresDbConnector : DbConnector
{
    public PostgresDbConnector(string connectionString) 
        : base(connectionString)
    {
        ConnectionString = connectionString;
    }

    public override Connection Connect()
    {
        Console.WriteLine("Connecting to Postgres...");
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}
