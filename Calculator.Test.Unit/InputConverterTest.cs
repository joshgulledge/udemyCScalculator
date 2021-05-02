using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
     [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void convertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConverterInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void failsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "&";
            double convertedNumber = _inputConverter.ConverterInputToNumeric(inputNumber);
        }
    }
}
