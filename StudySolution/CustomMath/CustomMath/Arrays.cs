using System;
using System.Collections.Generic;

namespace CustomMath
{
    public static class Arrays
    {
        private static Random random;

        static Arrays()
        {
            random = new Random((int)(DateTime.Now.Ticks));
        }

        public static bool Invert(int[] array)
        {
            if (array == null)
            {
                return false;
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }

            return true;
        }

        public static int[,] FillHelix(int sizeY, int sizeX)
        {
            if ((!sizeX.IsNatural()) & (!sizeY.IsNatural()))
            {
                return null;
            }

            var array = new int[sizeX, sizeY];

            var sum = sizeX * sizeY;
            var correctY = 0;
            var correctX = 0;
            var startNumber = 1;

            while (sizeY > 0)
            {
                for (var side = 0; side < 4; side++)
                {
                    for (var x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
                    {
                        switch (side)
                        {
                            case 0 when (x < sizeX - correctX) && (startNumber <= sum):
                                array[side + correctY, x + correctX] = startNumber++;
                                break;
                            case 1 when (x < sizeY - correctY) && (x != 0) && (startNumber <= sum):
                                array[x + correctY, sizeX - 1] = startNumber++;
                                break;
                            case 2 when (x < sizeX - correctX) && (x != 0) && (startNumber <= sum):
                                array[sizeY - 1, sizeX - (x + 1)] = startNumber++;
                                break;
                            case 3 when (x < sizeY - (correctY + 1)) && (x != 0) && (startNumber <= sum):
                                array[sizeY - (x + 1), correctY] = startNumber++;
                                break;
                        }
                    }
                }

                sizeY--;
                sizeX--;
                correctY += 1;
                correctX += 1;
            }

            return array;
        }

        public static int GetMax(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

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

        public static double GetMax(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

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
            if (array == null)
            {
                throw new ArgumentNullException();
            }

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

        public static double GetMin(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

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
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            var sum = 0;

            foreach (var arr in array)
            {
                sum += arr;
            }

            return sum;
        }

        public static double GetSum(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            double sum = 0;

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

        public static double GetMinMaxDiff(double[] array)
        {
            return GetMax(array) - GetMin(array);
        }

        public static void IncreaseEvenElementsByMaxOddDecreaseByMin(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = ((i + 1).IsEven()) ? array[i] + GetMax(array) : array[i] - GetMin(array);
            }
        }

        public static IEnumerable<int> FillRandom(int size, int min = sbyte.MinValue, int max = sbyte.MaxValue)
        {
            if (!size.IsNatural())
            {
                return null;
            }

            var array = new int[size];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }

        public static IEnumerable<int> Sum(int[] array1, int[] array2)
        {
            if ((array1 == null) || (array2 == null))
            {
                throw new ArgumentNullException();
            }

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

        public static bool GetMinMaxSum(int[] array, out int min, out int max, out int sum)
        {
            min = default;
            max = default;
            sum = default;

            if (array == null)
            {
                return false;
            }

            min = GetMin(array);
            max = GetMax(array);
            sum = GetSum(array);

            return true;
        }

        public static bool GetMinMaxSum(double[] array, out double min, out double max, out double sum)
        {
            min = default;
            max = default;
            sum = default;

            if (array == null)
            {
                return false;
            }

            min = GetMin(array);
            max = GetMax(array);
            sum = GetSum(array);

            return true;
        }

        public static (int min, int max, int sum) GetMinMaxSum(int[] array)
        {
            return (GetMin(array), GetMax(array), GetSum(array));
        }

        public static (double min, double max, double sum) GetMinMaxSum(double[] array)
        {
            return (GetMin(array), GetMax(array), GetSum(array));
        }

        public static IEnumerable<int> IncreaseItemBy5(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            return array;
        }

        public static IEnumerable<double> IncreaseItemBy5(this double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            return array;
        }
    }
}
