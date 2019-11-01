using System;
using GameComponents;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = (5, 6);
            var y = (6, 5);
            if (x == y)
                Console.WriteLine("1");

            Console.ReadKey();
        }
    }
}
