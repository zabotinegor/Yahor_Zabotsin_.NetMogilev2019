using System;

namespace Task1
{
    class Program
    {
        const int Income = 500;
        static void Main(string[] args)
        {
            Console.WriteLine("Number of companies: ");

            if (int.TryParse(Console.ReadLine(), out var companyCount))
            {
                Console.WriteLine("Tax percentage (%): ");

                if (double.TryParse(Console.ReadLine(), out var taxPercentage))
                {
                    Console.WriteLine($"Taxes from all companies will be {companyCount * Income * (taxPercentage / 100)}.");
                }
                else
                {
                    Console.WriteLine("Wrong percentage!");
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }

            Console.ReadKey();
        }
    }
}
