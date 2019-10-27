using System;
using CustomMath;
using InputLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter count of array: ", out var n))
            {
                Arrays.FillRandom(n, out var array);

                foreach (var arr in array)
                {
                    Console.Write($"{arr} ");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            Console.ReadKey();
        }
    }
}
