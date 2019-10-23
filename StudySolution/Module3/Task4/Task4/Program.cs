using System;
using CustomMath;
using InputLib;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InputData.NatData("Enter your number: ", out var number)
                ? $"Number after flip: {Integers.FlipNumber(number)}"
                : "Invalid number!");

            Console.ReadKey();
        }
    }
}
