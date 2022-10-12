namespace DesignPatterns.Structural.Adapter.Adaptee;

public interface IDbLogger
{
    void LogInDb(string message);
    void LogExceptionInDb(Exception exception);
}
