using System;
using CustomMath;
using System.Collections.Generic;
using System.Linq;
using static InputLib.InputData;
using static System.Console;

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

                {
                    WriteLine("\nSource array:");

                    DisplayArray(array);
                }

                {
                    WriteLine("\nSorting array via LINQ:");

                    DisplayArray(array.OrderBy(arr => arr));

                    WriteLine("\nSorting reverse array via LINQ:");

                    DisplayArray(array.OrderByDescending(arr => arr));
                }

                {
                    WriteLine("\nSorting array via Array.Sort()");

                    Array.Sort(array);

                    DisplayArray(array);

                    WriteLine("\nSorting reverse array via Array.Sort()");

                    Array.Sort(array, (x, y) => -x.CompareTo(y));

                    DisplayArray(array);
                }

                {
                    WriteLine("\nSorting array via Arrays.BubbleSort()");

                    DisplayArray(array.BubbleSort());

                    WriteLine("\nSorting reverse array via Arrays.BubbleSort()");

                    DisplayArray(array.BubbleSort(Arrays.DESC));
                }

                {
                    WriteLine("\nSorting array via Arrays.ShakerSort()");

                    DisplayArray(array.ShakerSort());

                    WriteLine("\nSorting reverse array via Arrays.ShakerSort()");

                    DisplayArray(array.ShakerSort(Arrays.DESC));
                }

                {
                    WriteLine("\nSorting array via Arrays.InsertionSort()");

                    DisplayArray(array.InsertionSort());

                    WriteLine("\nSorting reverse array via Arrays.InsertionSort()");

                    DisplayArray(array.InsertionSort(Arrays.DESC));
                }

                {
                    WriteLine("\nSorting array via Arrays.StoogeSort()");

                    DisplayArray(array.StoogeSort());

                    WriteLine("\nSorting reverse array via Arrays.StoogeSort()");

                    DisplayArray(array.StoogeSort(Arrays.DESC));
                }

                {
                    WriteLine("\nSorting array via Arrays.ShellSort()");

                    DisplayArray(array.ShellSort());

                    WriteLine("\nSorting reverse array via Arrays.ShellSort()");

                    DisplayArray(array.ShellSort(Arrays.DESC));
                }

            }
            else
            {
                WriteLine("Invalid size!");
            }

            ReadKey();
        }

        public static void DisplayArray<T>(IEnumerable<T> array)
        {
            foreach (var arr in array)
            {
                Write($"{arr} ");
            }

            WriteLine();
        }
    }
}
