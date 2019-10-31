using CustomMath;
using System;
using System.Linq;
using InputLib;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");

            if (InputData.NatData(Console.ReadLine(), out var n))
            {
                var array = Arrays.FillRandomInt(n).ToArray();

                Console.WriteLine("Source array: ");

                foreach (var arr in array)
                {
                    Console.Write($"{arr} ");
                }

                Console.WriteLine($"\nMinimum element in an array via LINQ: {array.Min()}");
                Console.WriteLine($"Minimum element in an array via custom method: {Arrays.GetMin(array)}");

                Console.WriteLine($"Maximum element in an array via LINQ: {array.Max()}");
                Console.WriteLine($"Maximum element in an array via custom method: {Arrays.GetMax(array)}");

                Console.WriteLine($"Sum of array elements via LINQ: {array.Sum()}");
                Console.WriteLine($"Sum of array elements via custom method: {Arrays.GetSum(array)}");

                Console.WriteLine($"The difference between the maximum and minimum element: {Arrays.GetMinMaxDiff(array)}");
                Console.WriteLine($"Increase the even elements of the array by the maximum element, the odd decrease by the minimum element: ");

                Arrays.IncreaseEvenElementsByMaxOddDecreaseByMin(array);

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
