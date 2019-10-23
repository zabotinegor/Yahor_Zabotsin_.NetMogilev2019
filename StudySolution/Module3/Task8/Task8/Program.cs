using CustomMath;
using InputLib;
using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter length: ", out var length) &&
                InputData.NatData("Enter width: ", out var width))
            {
                var array = new int[length, width];

                Arrays.FillHelix(ref array, array.GetLength(0), array.GetLength(1));
                Console.WriteLine();

                for (var i = 0; i < array.GetLength(0); i++)
                {
                    for (var j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", array[i, j]);
                    }

                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid parameters!");
            }

            Console.ReadKey();
        }
    }
}
