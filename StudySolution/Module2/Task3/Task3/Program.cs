using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first one: ");

            if (double.TryParse(Console.ReadLine().Replace('.', ','), out var firstOne))
            {
                Console.WriteLine("Enter second one: ");

                if (double.TryParse(Console.ReadLine().Replace('.', ','), out var secondOne))
                {
                    firstOne -= secondOne;
                    secondOne += firstOne;
                    firstOne = secondOne - firstOne;

                    Console.WriteLine($"After swap: first one = {firstOne}, second one = {secondOne}");
                }
                else
                {
                    Console.WriteLine("Wrong second number.");
                }
            }
            else
            {
                Console.WriteLine("Wrong first number.");
            }

            Console.ReadKey();
        }
    }
}
