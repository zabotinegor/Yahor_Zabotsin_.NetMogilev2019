using System;
using System.Linq;
using CustomMath;
using InputLib;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var intA = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intB = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intC = random.Next(sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine($"Initial numbers: {intA}, {intB}, {intC}");

            var numbers = Integers.IncreaseBy10(intA, intB, intC);

            Console.WriteLine($"Numbers after increasing by 10: {numbers.number1}, {numbers.number2}, {numbers.number3}");
            Console.WriteLine("Enter radius:");

            if (InputData.DoubleData(Console.ReadLine(), out var radius))
            {
                var parameters = Сircle.GetParams(radius);

                Console.WriteLine("Radius - {0:f4}\nPerimeter - {1:f4}\nArea - {2:f4}", radius, parameters.perimeter, parameters.area);
            }
            else
            {
                Console.WriteLine("Invalid radius!");
            }

            Console.WriteLine("Enter size of array:");

            if (InputData.NatData(Console.ReadLine(), out var size))
            {
                var array = Arrays.FillRandom(size).ToArray();

                Console.WriteLine("Source array:");

                foreach (var arr in array)
                {
                    Console.Write($"{arr} ");
                }

                var minMaxSum = Arrays.GetMinMaxSum(array);

                Console.WriteLine($"\nMin - {minMaxSum.min}\nMax - {minMaxSum.max}\nSum - {minMaxSum.sum}");
            }
            else
            {
                Console.WriteLine("Invalid size!");
            }

            Console.ReadLine();
        }
    }
}
