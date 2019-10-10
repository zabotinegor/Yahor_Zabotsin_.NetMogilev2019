using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");

            if (int.TryParse(Console.ReadLine(), out var age))
            {
                if ((age % 2 == 0) && (age > 18))
                {
                    Console.WriteLine("Congratulations! Childhood is over!");
                }
                else if ((age % 2 != 0) && ((13 < age) && (age < 18)))
                {
                    Console.WriteLine("Congratulations. You are a high school student.");
                }
            }
            else
            {
                Console.WriteLine("Wrong age.");
            }

            Console.ReadKey();
        }
    }
}
