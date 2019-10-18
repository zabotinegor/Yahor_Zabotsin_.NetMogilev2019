using System;
using CustomMath;
using InputLib;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData.NatData("Enter your number: ", out var number);
            Console.WriteLine($"Number after flip: {Integers.FlipNumber(number)}"); 
            
            Console.ReadKey();
        }
    }
}
