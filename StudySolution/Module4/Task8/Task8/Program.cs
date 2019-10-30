using System;
using CustomMath;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f(x) = -3 * x + 6");
            Console.WriteLine($"x = {Roots.Root(3, -2, 0.00000001, x => -3 * x + 6)}");
            Console.WriteLine("f(x) = x * x + 6 * x + 7  (-2; 0)");
            Console.WriteLine($"x = {Roots.Root(0, -2, 0.00000001, x => Math.Pow(x, 2) + 6 * x + 7)}");
            Console.WriteLine("f(x) = x * x + 6 * x + 7  (-5; -2)");
            Console.WriteLine($"x = {Roots.Root(-5, -2, 0.1, x => Math.Pow(x, 2) + 6 * x + 7)}");

            Console.ReadKey();
        }
    }
}
