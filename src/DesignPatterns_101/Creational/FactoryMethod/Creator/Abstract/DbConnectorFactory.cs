using DesignPatterns.Creational.FactoryMethod.Creator.Concrete;
using DesignPatterns.Creational.FactoryMethod.Product.Abstract;

namespace DesignPatterns.Creational.FactoryMethod.Creator.Abstract;

/// <summary>
/// Abstract Creator
/// </summary>
public abstract class DbConnectorFactory
{
    /// <summary>
    /// Factory Method
    /// </summary>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    public abstract DbConnector CreateConnector(string connectionString);

    /// <summary>
    /// Database type selector
    /// </summary>
    /// <param name="dataBase"></param>
    /// <returns></returns>
    public static DbConnectorFactory ForDatabase(DataBaseNames dataBase)
    {
        DbConnectorFactory dbFactory = dataBase switch
        {
            DataBaseNames.SqlServer => new SqlServerConnectionFactory(),
            DataBaseNames.Oracle => new OracleConnectionFactory(),
            DataBaseNames.Postgres => new PostgresConnectionFactory(),
            _ => throw new ArgumentException("Not implemented database type."),
        };

        return dbFactory;
    }
}