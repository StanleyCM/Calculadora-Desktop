namespace Calculadora.Core;

public enum CalculatorOperation
{
    Add,
    Subtract,
    Multiply,
    Divide,
    Power
}

public sealed class CalculatorService
{
    public decimal Add(decimal firstNumber, decimal secondNumber) =>
        firstNumber + secondNumber;

    public decimal Subtract(decimal firstNumber, decimal secondNumber) =>
        firstNumber - secondNumber;

    public decimal Multiply(decimal firstNumber, decimal secondNumber) =>
        firstNumber * secondNumber;

    public decimal Divide(decimal firstNumber, decimal secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero.");
        }

        return firstNumber / secondNumber;
    }

    public decimal Power(decimal number, decimal exponent) =>
        FromDouble(Math.Pow((double)number, (double)exponent));

    public decimal SquareRoot(decimal number)
    {
        if (number < 0)
        {
            throw new ArithmeticException("No existe una raíz real de un número negativo.");
        }

        return FromDouble(Math.Sqrt((double)number));
    }

    public decimal NaturalLogarithm(decimal number) =>
        number > 0
            ? FromDouble(Math.Log((double)number))
            : throw new ArithmeticException("El logaritmo requiere un número positivo.");

    public decimal Base10Logarithm(decimal number) =>
        number > 0
            ? FromDouble(Math.Log10((double)number))
            : throw new ArithmeticException("El logaritmo requiere un número positivo.");

    public decimal Sine(decimal angle, bool degrees) =>
        FromDouble(Math.Sin(ToRadians((double)angle, degrees)));

    public decimal Cosine(decimal angle, bool degrees) =>
        FromDouble(Math.Cos(ToRadians((double)angle, degrees)));

    public decimal Tangent(decimal angle, bool degrees) =>
        FromDouble(Math.Tan(ToRadians((double)angle, degrees)));

    public decimal ArcSine(decimal number, bool degrees)
    {
        if (number is < -1 or > 1)
        {
            throw new ArithmeticException("El arco seno requiere un valor entre -1 y 1.");
        }

        return FromDouble(FromRadians(Math.Asin((double)number), degrees));
    }

    public decimal ArcCosine(decimal number, bool degrees)
    {
        if (number is < -1 or > 1)
        {
            throw new ArithmeticException("El arco coseno requiere un valor entre -1 y 1.");
        }

        return FromDouble(FromRadians(Math.Acos((double)number), degrees));
    }

    public decimal ArcTangent(decimal number, bool degrees) =>
        FromDouble(FromRadians(Math.Atan((double)number), degrees));

    public decimal Calculate(
        decimal firstNumber,
        decimal secondNumber,
        CalculatorOperation operation) =>
        operation switch
        {
            CalculatorOperation.Add => Add(firstNumber, secondNumber),
            CalculatorOperation.Subtract => Subtract(firstNumber, secondNumber),
            CalculatorOperation.Multiply => Multiply(firstNumber, secondNumber),
            CalculatorOperation.Divide => Divide(firstNumber, secondNumber),
            CalculatorOperation.Power => Power(firstNumber, secondNumber),
            _ => throw new ArgumentOutOfRangeException(
                nameof(operation),
                operation,
                "La operación indicada no es válida.")
        };

    public decimal Percentage(decimal number) => number / 100m;

    public decimal ToggleSign(decimal number) => -number;

    private static double ToRadians(double angle, bool degrees) =>
        degrees ? angle * Math.PI / 180d : angle;

    private static double FromRadians(double angle, bool degrees) =>
        degrees ? angle * 180d / Math.PI : angle;

    private static decimal FromDouble(double value)
    {
        if (double.IsNaN(value) || double.IsInfinity(value) ||
            value > (double)decimal.MaxValue || value < (double)decimal.MinValue)
        {
            throw new OverflowException("El resultado está fuera del rango permitido.");
        }

        return (decimal)value;
    }
}
