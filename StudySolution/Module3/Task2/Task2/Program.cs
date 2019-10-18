using CustomMath;
using InputLib;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData.NatData("Enter your number: ", out var number);

            var count = 0;
            
            Console.WriteLine($"The first {number} even numbers:");

            for (var i = 1; count < number; i++)
            {
                if (!i.IsEven()) continue;
                Console.WriteLine($"{i}");
                count++;
            }

            Console.ReadKey();
        }
    }
}
