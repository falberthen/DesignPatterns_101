using DesignPatterns.Behavioral.Command.Receiver;

namespace DesignPatterns.Behavioral.Command;

/// <summary>
/// The 'ConcreteCommand' class
/// </summary>
public class CalculatorCommand : Command
{
    private int _value;
    private char _operator;
    private readonly Calculator _calculator;

    public CalculatorCommand(Calculator calculator, char operador, int valor)
    {
        _calculator = calculator;
        _operator = operador;
        _value = valor;
    }

    public char Operator
    {
        set => _operator = value;
    }

    public int Operand
    {
        set => _value = value;
    }

    public override void Execute()
    {
        _calculator.Operation(_operator, _value);
    }

    public override void UnExecute()
    {
        _calculator.Operation(Undo(_operator), _value);
    }

    private static char Undo(char @operator)
    {
        char op = @operator switch
        {
            '+' => '-',
            '-' => '+',
            '*' => '/',
            '/' => '*',
            _ => throw new ArgumentException("Unknown operator."),
        };

        return op;
    }
}
