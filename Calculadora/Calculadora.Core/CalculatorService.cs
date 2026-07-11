namespace Calculadora.Core;

public enum CalculatorOperation
{
    Add,
    Subtract,
    Multiply,
    Divide
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
            _ => throw new ArgumentOutOfRangeException(
                nameof(operation),
                operation,
                "La operación indicada no es válida.")
        };

    public decimal Percentage(decimal number) => number / 100m;

    public decimal ToggleSign(decimal number) => -number;
}
