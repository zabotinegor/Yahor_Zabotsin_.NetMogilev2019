using CustomMath;
using System;
using InputLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InputData.IntData("Enter multiplier", out var firstOne, out var secondOne)
                ? $"Result - {Multiplication.AdditionMultiplication(firstOne, secondOne)}"
                : "Invalid multiplier!");

            Console.ReadKey();
        }
    }
}
