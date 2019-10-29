using System.Linq;
using CustomMath;
using static System.Console;
using static InputLib.InputData;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter size of array:");

            if (NatData(ReadLine(), out var size))
            {
                var array = Arrays.FillRandom(size).ToArray();

                WriteLine("Source array:");

                foreach (var arr in array)
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
