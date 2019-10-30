using System;
using CustomMath;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Roots.Root(-10, 3, 0.00000001, x => 3 * x + 6);

            Console.ReadKey();
        }
    }
}
