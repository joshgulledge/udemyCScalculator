using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Equals("Avatar"))
            {
                Console.WriteLine("Hello blue man");
            }
            else if (input.Equals("Joe"))
            {
                Console.WriteLine("Hello Mr. Mean");
            }
            else
            {
                Console.WriteLine("Sup Guesto");
            }

            switch (input)
            {
                case "Avatar":
                    Console.WriteLine("Hello blue man");
                    break;
                case "Joe":
                    Console.WriteLine("Hello Mr. Mean");
                    break;
                default:
                    Console.WriteLine("Sup Guesto");
                    break;
            }
        }
    }
}
