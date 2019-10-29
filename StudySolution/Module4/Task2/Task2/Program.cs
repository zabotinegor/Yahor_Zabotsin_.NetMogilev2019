using System;
using CustomMath;
using InputLib;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int) DateTime.Now.Ticks);
            var intA = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intB = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var intC = random.Next(sbyte.MinValue, sbyte.MaxValue);
            var doubleA = random.NextDouble();
            var doubleB = random.NextDouble();
            var doubleC = random.NextDouble();
            var string1 = "Hello, ";
            var string2 = "world!";

            Console.WriteLine($"The sum of three integers via the addition operator ({intA}, {intB}, {intC}): {intA + intB + intC}");
            Console.WriteLine($"The sum of three integers via custom method ({intA}, {intB}, {intC}): {Integers.Sum(intA, intB, intC)}");
            Console.WriteLine($"The sum of two integers via the addition operator ({intA}, {intB}): {intA + intB}");
            Console.WriteLine($"The sum of two integers via custom method ({intA}, {intB}): {Integers.Sum(intA, intB)}");
            Console.WriteLine("The sum of three fractional numbers via the addition operator ({0:f4}, {1:f4}, {2:f4}): {3:f4}", doubleA, doubleB, doubleC, doubleA + doubleB + doubleC);
            Console.WriteLine("The sum of three fractional numbers via custom method ({0:f4}, {1:f4}, {2:f4}): {3:f4}", doubleA, doubleB, doubleC, Doubles.Sum(doubleA, doubleB, doubleC));
            Console.WriteLine($"Sum of two strings via custom method (\"{string1}\", \"{string2}\"): {Strings.Sum(string1, string2)}");
            Console.WriteLine("Enter the size of the first array: ");

            if (InputData.NatData(Console.ReadLine(), out var size1))
            {
                Console.WriteLine("Enter the size of the second array: ");

                if (InputData.NatData(Console.ReadLine(), out var size2))
                {
                    Arrays.FillRandom(size1, out var array1);

                    Console.WriteLine("First array:");

                    foreach (var arr in array1)
                    {
                        Console.Write($"{arr} ");
                    }
                    
                    Arrays.FillRandom(size2, out var array2);
                    
                    Console.WriteLine("\nSecond array:");

                    foreach (var arr in array2)
                    {
                        Console.Write($"{arr} ");
                    }

                    Console.WriteLine("\nSum of Arrays:");

                    foreach (var arr in Arrays.Sum(array1, array2))
                    {
                        Console.Write($"{arr} ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid size of the second array!");
                }
            }
            else
            {
                Console.WriteLine("Invalid size of first array!");
            }

            Console.ReadKey();
        }
    }
}
