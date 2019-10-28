﻿using System;
using System.Collections.Generic;

namespace CustomMath
{
    public static class Arrays
    {
        public static bool Invert(ref int[] array)
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

        public static void FillHelix(ref int[,] array, int sizeY, int sizeX)
        {
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

        public static double GetMin(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            var max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < max)
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

            var max = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < max)
                {
                    max = array[i];
                }
            }

            return max;
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

        public static void IncreaseEvenElementsByMaxOddDecreaseByMin(ref int[] array)
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

        public static void FillRandom(int n, out int[] array, int min = sbyte.MinValue, int max = sbyte.MaxValue)
        {
            array = new int[n];

            var rand = new Random((int) (DateTime.Now.Ticks));

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }
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
    }
}
