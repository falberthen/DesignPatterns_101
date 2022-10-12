namespace DesignPatterns.Behavioral.Command.Receiver;

/// <summary>
/// The 'Receiver' class
/// </summary>
public class Calculator
{

    public void Operation(char @operator, int operand)
    {
        var initialValue = 0;

        var currentValue = @operator switch
        {
            '+' => initialValue += operand,
            '-' => initialValue -= operand,
            '*' => initialValue *= operand,
            '/' => initialValue /= operand,
            _ => throw new ArgumentException("Invalid operation."),
        };

        Console.WriteLine("{1} {2} = {0}", currentValue, @operator, operand);
    }
}