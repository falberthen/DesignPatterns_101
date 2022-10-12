namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// This class was designed to demonstrate 
/// the usage of Singleton pattern
/// </summary>
public class SingletonRunner
{
    public static void Execute()
    {
        var b1 = LoadBalancer.GetLoadBalancer();
        var b2 = LoadBalancer.GetLoadBalancer();

        if (b1 == b2)
            Console.WriteLine("Single instance\n");        

        var balancer = LoadBalancer.GetLoadBalancer();

        for (var i = 0; i < 15; i++)
        {
            var serverName = balancer.NextServer.Name;
            var serverGuid = balancer.NextServer.Id;
            var serverIP = balancer.NextServer.IP;
            Console.WriteLine($"Requesting server [{serverGuid}-{serverName}] - IP {serverIP}");
        }
    }
}
