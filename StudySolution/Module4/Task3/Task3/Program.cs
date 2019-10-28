using System;
using CustomMath;
using InputLib;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var intA = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intB = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intC = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var doubleA = random.NextDouble();
            var doubleB = random.NextDouble();
            var doubleC = random.NextDouble();

            Console.WriteLine($"Three integers before increase by 10: {intA}, {intB}, {intC}");

            Integers.IncreaseBy10(ref intA, ref intB, ref intC);

            Console.WriteLine($"Three integers after increase by 10: {intA}, {intB}, {intC}");
            Console.WriteLine("Enter circle radius: ");

            if (InputData.DoubleData(out var radius, Console.ReadLine()))
            {
                Сircle.GetParams(radius, out var perimeter, out var area);

                Console.WriteLine("Circle radius: {0:f4}\nCircle perimeter: {1:f4}\nCircle area: {2:f4}", radius, perimeter, area);
            }
            else
            {
                Console.WriteLine("Invalid radius!");
            }

            Console.ReadKey();
        }
    }
}
