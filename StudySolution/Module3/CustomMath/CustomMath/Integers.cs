using System.Collections.Generic;
using System.Linq;

namespace CustomMath
{
    public static class Integers
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsDigit(this int number)
        {
            return (0 <= number) && (number <= 9);
        }

        public static IEnumerable<int> Fibonacci(int n)
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
            switch (num)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return CalcForFibonacci(num - 1) + CalcForFibonacci(num - 2);
            }
        }

        public static int FlipNumber(int number)
        {
            var digitList = new List<int>();
            var result = 0;

            do
            {
                digitList.Add(number % 10);
                number /= 10;
            } while (number != 0);
            
            foreach (var digit in digitList)
            {
                result += digit;
                result *= 10;
            }

            return result / 10;
        }

        public static bool DeleteDigit(int number, int digit, out int newNumber)
        {
            var digitList = new List<int>();
            newNumber = default;

            do
            {
                digitList.Add(number % 10);
                number /= 10;
            } while (number != 0);
            
            foreach (var dig in digitList.Where(dig => dig != digit).Reverse())
            {
                newNumber += dig;
                newNumber *= 10;
            }

            newNumber /= 10;

            return digitList.Contains(digit);
        }
    }
}
