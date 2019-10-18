using CustomMath;
using InputLib;
using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter your number: ", out var num))
            {
                if (InputData.NatData("Enter the number to delete: ", out var digit) && digit.IsDigit())
                {
                    Console.WriteLine(Integers.DeleteDigit(num, digit, out var newNumber)
                        ? $"Number after deleting a digit - {newNumber}"
                        : "There is no given figure");
                }
                else
                {
                    Console.WriteLine("Invalid digit!");
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
