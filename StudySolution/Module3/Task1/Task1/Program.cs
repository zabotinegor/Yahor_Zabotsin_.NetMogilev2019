using CustomMath;
using System;
using InputLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.IntData("Enter multiplier", out var firstOne, out var secondOne))
            {
                Console.WriteLine($"Result - {Multiplication.AdditionMultiplication(firstOne, secondOne)}");
            }
            else
            {
                Console.WriteLine("Invalid multiplier!");
            }

            Console.ReadKey();
        }
    }
}
