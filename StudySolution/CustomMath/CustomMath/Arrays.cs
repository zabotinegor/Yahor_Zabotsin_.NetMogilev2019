using System;
using System.Collections.Generic;

namespace CustomMath
{
    public enum Direction
    {
        Asc,
        Desc
    }

    public static class Arrays
    {
        private static readonly Random Random;

        static Arrays()
        {
            Random = new Random((int)(DateTime.Now.Ticks));
        }

        public static int GetMax(int[] array)
        {
            CheckArray(array);

            var max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int GetMin(int[] array)
        {
            CheckArray(array);

            var min = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int GetSum(int[] array)
        {
            CheckArray(array);

            var sum = 0;

            foreach (var arr in array)
            {
                sum += arr;
            }

            return sum;
        }

        public static int GetMinMaxDiff(int[] array)
        {
            return GetMax(array) - GetMin(array);
        }

        public static void IncreaseEvenElementsByMaxOddDecreaseByMin(int[] array)
        {
            CheckArray(array);

            var max = GetMax(array);
            var min = GetMin(array);

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = ((i + 1).IsEven()) ? array[i] + max : array[i] - min;
            }
        }

        public static IEnumerable<int> FillRandomInt(int size, int min = sbyte.MinValue, int max = sbyte.MaxValue)
        {
            if (!size.IsNatural())
            {
                return null;
            }

            var array = new int[size];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Random.Next(min, max);
            }

            return array;
        }

        public static IEnumerable<int> Sum(int[] array1, int[] array2)
        {
            CheckArray(array1);
            CheckArray(array2);

            var newArray = new int[(array1.Length <= array2.Length) ? array2.Length : array1.Length];

            for (var i = 0; i < newArray.Length; i++)
            {
                if (i >= array1.Length)
                {
                    newArray[i] = array2[i];
                }
                else if (i >= array2.Length)
                {
                    newArray[i] = array1[i];
                }
                else
                {
                    newArray[i] = array1[i] + array2[i];
                }
            }

            return newArray;
        }

        public static void GetMinMaxSum(int[] array, out int min, out int max, out int sum)
        {
            CheckArray(array);

            min = GetMin(array);
            max = GetMax(array);
            sum = GetSum(array);
        }

        public static (int min, int max, int sum) GetMinMaxSum(int[] array)
        {
            return (GetMin(array), GetMax(array), GetSum(array));
        }

        public static IEnumerable<int> IncreaseItemsBy5(this int[] array)
        {
            CheckArray(array);
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            return array;
        }

        public static IEnumerable<int> BubbleSort(this int[] array, Direction directDirection = Direction.Asc)
        {
            CheckArray(array);

            var len = array.Length;

            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if ((directDirection == Direction.Asc) ? (array[j] > array[j + 1]) : (array[j] < array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        public static IEnumerable<int> ShakerSort(this int[] array, Direction directDirection = Direction.Asc)
        {
            CheckArray(array);

            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if ((directDirection == Direction.Asc) ? (array[j] > array[j + 1]) : (array[j] < array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);

                        swapFlag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if ((directDirection == Direction.Asc) ? (array[j - 1] > array[j]) : (array[j - 1] < array[j]))
                    {
                        Swap(ref array[j - 1], ref array[j]);

                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }

        private static void CheckArray(int[] array)
        {
            if ((array == null) || (array.Length == 0))
            {
                throw new ArgumentNullException(nameof(array));
            }
        }

        private static void Swap<T>(ref T item1, ref T item2)
        {
            var temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
