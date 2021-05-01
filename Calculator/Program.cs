using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine(person1.getAge());
            person1.setAge(29);
            Console.WriteLine(person1.getAge());

            Person.greet();
        }
    }
}
