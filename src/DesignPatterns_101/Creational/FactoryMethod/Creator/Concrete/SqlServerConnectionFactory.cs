using DesignPatterns.Creational.FactoryMethod.Creator.Abstract;
using DesignPatterns.Creational.FactoryMethod.Product.Abstract;
using DesignPatterns.Creational.FactoryMethod.Product.Concrete;

namespace DesignPatterns.Creational.FactoryMethod.Creator.Concrete;

/// <summary>
/// Concrete Creator
/// </summary>
public class SqlServerConnectionFactory : DbConnectorFactory
{
    /// <summary>
    /// Factory Method
    /// </summary>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    public override DbConnector CreateConnector(string connectionString)
    {
        return new SqlServerDbConnector(connectionString);
    }
}
