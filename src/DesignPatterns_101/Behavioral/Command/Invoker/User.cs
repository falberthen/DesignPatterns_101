using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command.Invoker;

/// <summary>
/// The Invoker class
/// </summary>
class User

{
    // Initializers
    private Calculator _calculator = new Calculator();
    private List<Command> _commands = new List<Command>();
    private int _currentCommand = 0;

    public void Redo(int levels)
    {
        Console.WriteLine("\n---- Redo {0} levels ", levels);

        // Perform redo operations
        for (int i = 0; i < levels; i++)
        {
            if (_currentCommand < _commands.Count - 1)
            {
                Command command = _commands[_currentCommand++];
                command.Execute();
            }
        }
    }

    public void Undo(int levels)
    {
        Console.WriteLine("\n---- Undo {0} levels ", levels);

        // Perform undo operations
        for (int i = 0; i < levels; i++)
        {
            if (_currentCommand > 0)
            {
                Command command = _commands[--_currentCommand];
                command.UnExecute();
            }
        }
    }

    public void Compute(char @operator, int operand)
    {
        // Create command operation and execute it
        Command command = new CalculatorCommand(_calculator, @operator, operand);
        command.Execute();

        // Add command to undo list
        _commands.Add(command);
        _currentCommand++;
    }
}
