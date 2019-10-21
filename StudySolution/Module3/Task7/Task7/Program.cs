using System;
using InputLib;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputData.NatData("Enter size: ", out var size))
            {
                if (InputData.IntArray($"Enter {size} elemets: ", size, out var array))
                {
                    var previosElement = 0;

                    Console.WriteLine("Elements: ");

                    for (var i = 0; i < array.Length; i++)
                    {
                        
                        if (i == 0)
                        {
                            previosElement = array[i];
                            continue;
                        }
                        else if (previosElement < array[i])
                        {
                            Console.WriteLine($"{array[i]}");
                        }
                        previosElement = array[i];
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
