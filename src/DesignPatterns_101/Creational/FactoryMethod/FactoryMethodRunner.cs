using DesignPatterns.Creational.FactoryMethod.Creator.Abstract;

namespace DesignPatterns.Creational.FactoryMethod;

/// <summary>
/// This class was designed to demonstrate 
/// the usage of FactoryMethod pattern
/// </summary>
public class FactoryMethodRunner
{
    private const string _connstring = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

    public static void Execute()
    {
        string sqlServerCommand = "SELECT * FROM SQL_TABLE";
        string oracleSqlCommand = "SELECT * FROM ORACLE_TABLE";
        string postgreSqlCommand = "SELECT * FROM POSTGRESQL_TABLE";

        var sqlServerConn = DbConnectorFactory
            .ForDatabase(DataBaseNames.SqlServer)
            .CreateConnector(_connstring)
            .Connect();

        sqlServerConn.ExecuteCommand(sqlServerCommand);
        sqlServerConn.Close();

        Console.WriteLine("\n--------------------------------\n");

        var oracleConn = DbConnectorFactory
            .ForDatabase(DataBaseNames.Oracle)
            .CreateConnector(_connstring)
            .Connect();

        oracleConn.ExecuteCommand(oracleSqlCommand);
        oracleConn.Close();

        Console.WriteLine("\n--------------------------------\n");

        var postgreSqlConn = DbConnectorFactory
            .ForDatabase(DataBaseNames.Postgres)
            .CreateConnector(_connstring)
            .Connect();

        postgreSqlConn.ExecuteCommand(postgreSqlCommand);
        postgreSqlConn.Close();
    }
}