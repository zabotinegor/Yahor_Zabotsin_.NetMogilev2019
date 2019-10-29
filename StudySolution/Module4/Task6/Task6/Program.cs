using CustomMath;
using System.Linq;
using static InputLib.InputData;
using static System.Console;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter size for array:");

            if (NatData(ReadLine(), out var size))
            {
                var array = Arrays.FillRandom(size).ToArray();

                WriteLine("Source array:");

                foreach (var arr in array)
                {
                    Write($"{arr} ");
                }

                WriteLine("\nArray after increasing elements by 5:");

                foreach (var arr in array.IncreaseItemBy5())
                {
                    Write($"{arr} ");
                }
            }
            else
            {
                WriteLine("Invalid size!");
            }

            ReadKey();
        }
    }
}
