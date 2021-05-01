using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                int convertedNumber;
                bool isConverted = int.TryParse(input, out convertedNumber);

                if (!isConverted)
                {
                    throw new Exception("Conversion didn't work");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            Console.WriteLine("App still running");

        }
    }
}
