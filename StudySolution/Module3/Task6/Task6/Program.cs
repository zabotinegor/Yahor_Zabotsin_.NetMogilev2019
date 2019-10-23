using System;
using CustomMath;
using InputLib;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter size: ", out var size))
            {
                if (InputData.IntArray($"Enter {size} elemets: ", size, out var array))
                {
                    if (Arrays.Invert(ref array))
                    {
                        Console.WriteLine("Array after invert: ");

                        foreach (var arr in array)
                        {
                            Console.WriteLine($"{arr}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cannot invert array!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid element!");
                }
            }
            else
            {
                Console.WriteLine("Invalid size!");
            }

            Console.ReadKey();
        }
    }
}
