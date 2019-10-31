using System;
using CustomMath;
using InputLib;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");

            if (InputData.DoubleData(Console.ReadLine(), out var firstOne))
            {
                Console.WriteLine("\nEnter second number:");

                if (InputData.DoubleData(Console.ReadLine(), out var secondOne))
                {
                    //чтобы красивее было, извините)
                    Console.WriteLine();
                    Console.WriteLine("1. Addition\n" +
                                      "2. Subtraction\n" +
                                      "3. Division\n" +
                                      "4. Multiplication\n");

                    if (InputData.NatData(Console.ReadLine(), out var item))
                    {
                        try
                        {
                            Console.WriteLine(
                                $"\nResult = {Calculate.Calculation(firstOne, secondOne, (CustomMath.Operations) item - 1)}");
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine("Wrong operation!");
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong operation!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong second number!");
                }
            }
            else
            {
                Console.WriteLine("Wrong first number!");
            }

            Console.ReadKey();
        }
    }
}
