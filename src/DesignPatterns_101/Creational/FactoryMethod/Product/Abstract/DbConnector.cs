namespace DesignPatterns.Creational.FactoryMethod.Product.Abstract;

/// <summary>
/// Abstract Product
/// </summary>
public abstract class DbConnector
{
    protected string ConnectionString { get; set; }

    public abstract Connection Connect();

    protected DbConnector(string connectionString)
    {
        ConnectionString = connectionString;
    }
}
