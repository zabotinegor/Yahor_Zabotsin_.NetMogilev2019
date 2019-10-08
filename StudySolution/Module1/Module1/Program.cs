using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;

            Console.WriteLine($"a = {a}, b = {b}");

            a -= b;
            b += a;
            a = b - a;

            Console.WriteLine($"a = {a}, b = {b}");

            Console.ReadKey();
        }
    }
}