using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some text";
            string moreText = "Now theres more text";
            //bool isEqual = someText.Equals(moreText, StringComparison.OrdinalIgnoreCase);
            string addedText = someText + " " + moreText;
            string formattedString = string.Format("{0} {1} here is even more text", someText, moreText);

            Console.WriteLine(addedText);
            Console.WriteLine(formattedString);

            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[6]);
            Console.WriteLine(someText.Substring(8, 4));

            string replacedText = someText.Replace("text", "string");
            Console.WriteLine(replacedText);
        }
    }
}
