using System;
using CustomMath;
using InputLib;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter count of numbers: ", out var n))
            {
                var fibonacci = Integers.Fibonacci(n);

                Console.WriteLine($"The first {n} Fibonacci numbers:");

                foreach (var fib in fibonacci)
                {
                    Console.WriteLine($"{fib}");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

            Console.ReadKey();
        }
    }
}
