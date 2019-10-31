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
                var array = Arrays.FillRandomInt(size).ToArray();

                WriteLine("\nSource array:");
                DisplayArray(array);

                #region LINQ_Sort

                WriteLine("\nSorting array via LINQ:");
                DisplayArray(array.OrderBy(arr => arr));

                WriteLine("\nSorting reverse array via LINQ:");
                DisplayArray(array.OrderByDescending(arr => arr));

                #endregion

                #region Array_Sort

                WriteLine("\nSorting array via Array.Sort()");
                Array.Sort(array);
                DisplayArray(array);

                WriteLine("\nSorting reverse array via Array.Sort()");
                Array.Sort(array, (x, y) => -x.CompareTo(y));
                DisplayArray(array);

                #endregion

                #region Bubble_Sort

                WriteLine("\nSorting array via Arrays.BubbleSort()");
                DisplayArray(array.BubbleSort());

                WriteLine("\nSorting reverse array via Arrays.BubbleSort()");
                DisplayArray(array.BubbleSort(Direction.Desc));
                #endregion

                #region Shaker_Sort

                WriteLine("\nSorting array via Arrays.ShakerSort()");
                DisplayArray(array.ShakerSort());

                WriteLine("\nSorting reverse array via Arrays.ShakerSort()");
                DisplayArray(array.ShakerSort(Direction.Desc));

                #endregion
                
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
