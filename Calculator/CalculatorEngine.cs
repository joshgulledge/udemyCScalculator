using System;
namespace Calculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argsOperation, double argsFirstNumber, double argsSecondNumber)
        {
            double result;

            switch (argsOperation.ToLower())
            {
                case "add":
                case "+":
                case "plus":
                case "addition":
                    result = argsFirstNumber + argsSecondNumber;
                    break;
                case "subtract":
                case "-":
                case "sub":
                case "minus":
                    result = argsFirstNumber - argsSecondNumber;
                    break;
                case "multiply":
                case "x":
                case "times":
                case "*":
                    result = argsFirstNumber * argsSecondNumber;
                    break;
                case "divide":
                case "/":
                case "divided by":
                case "over":
                    result = argsFirstNumber / argsSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Operation is not recognised");
            }
            return result;
        }
    }
}
