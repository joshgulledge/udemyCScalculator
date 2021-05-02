using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();

                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Please Enter Your First Number");
                double firstNumber = inputConverter.ConverterInputToNumeric(Console.ReadLine());

                Console.WriteLine("Please Enter The Operation");
                string operation = Console.ReadLine();

                Console.WriteLine("Please Enter Your Second Number");
                double secondNumber = inputConverter.ConverterInputToNumeric(Console.ReadLine());


                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(string.Format("The Result is {0}", result));

            } catch (Exception ex)
            {
                // In real world we would want to log this out
                Console.WriteLine(ex.Message);
            } finally
            {

            }
        }
    }
}
