using DesignPatterns.Behavioral.Command.Invoker;

namespace DesignPatterns.Behavioral.Command;

public class CommandRunner
{
    public static void Execute()
    {
        // Create user and let it compute
        var user = new User();

        // User presses buttons
        user.Compute('+', 100);
        user.Compute('-', 50);
        user.Compute('*', 10);
        user.Compute('/', 2);

        // Undo 4 commands
        user.Undo(4);

        // Redo 3 commands
        user.Redo(3);

        Console.ReadKey();
    }
}
