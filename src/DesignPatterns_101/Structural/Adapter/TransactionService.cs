using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter;

/// <summary>
/// Client
/// </summary>
public class TransactionService
{
    private readonly ILogger _logger;

    public TransactionService(ILogger logger)
    {
        _logger = logger;
    }

    public void LogTransation()
    {
        _logger.Log("Transaction logged");
    }
}
