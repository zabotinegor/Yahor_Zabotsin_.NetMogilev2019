﻿namespace CustomMath
{
    public static class Integers
    {
        public static int[] Fibonacci(int n)
        {
            var fibonacci = new int[n] ;

            for (var i = 0; i < fibonacci.Length; i++)
            {
                fibonacci[i] = CalcForFibonacci(i);
            }

            return fibonacci;
        }

        private static int CalcForFibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            return CalcForFibonacci(num - 1) + CalcForFibonacci(num - 2);
        }
    }
}
