using System;

namespace Calculator.Logic
{
    public class CalculatorEngine
    {
        public double Calculate(double left, double right, string op)
        {
            switch (op)
            {
                case "+":
                    return left + right;
                case "-":
                    return left - right;
                case "X":
                case "x":
                case "*":
                    return left * right;
                case "/":
                    if (right == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return left / right;
                default:
                    throw new ArgumentException($"Invalid operator: {op}");
            }
        }
    }
}
