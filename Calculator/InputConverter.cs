using System;
namespace Calculator
{
    public class InputConverter
    {
        public double ConverterInputToNumeric(string argsTextInput)
        {
            double convertedNumber;

            if (!double.TryParse(argsTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }

            return convertedNumber;
        }
    }
}
