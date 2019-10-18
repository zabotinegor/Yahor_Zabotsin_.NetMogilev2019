using System;

namespace InputLib
{
    public static class InputData
    {
        public static bool IntData(string message, out int data)
        {
            data = 0;
            var result = false;

            Console.WriteLine(message);

            if (int.TryParse(Console.ReadLine(), out data))
            {
                result = true;
            }
            else
            {
                Console.WriteLine("Wrong data!");
                data = 0;
            }

            return result;
        }

        public static bool IntData(string message, out int firstData, out int secondData)
        {
            firstData = 0;
            secondData = 0;
            var result = false;

            Console.WriteLine(message);
            Console.WriteLine("\nEnter first one!");

            if (int.TryParse(Console.ReadLine(), out firstData))
            {
                Console.WriteLine("Enter second one!");

                if (int.TryParse(Console.ReadLine(), out secondData))
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("Wrong second one!");
                    firstData = 0;
                    secondData = 0;
                }

            }
            else
            {
                Console.WriteLine("Wrong first one!");
                firstData = 0;
                secondData = 0;
            }

            return result;
        }

        public static bool NatData(string message, out int data)
        {
            data = 0;
            var result = false;

            Console.WriteLine(message);

            if (int.TryParse(Console.ReadLine(), out data))
            {
                if (data > 0)
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("Number is not natural!");
                    data = 0;
                }
            }
            else
            {
                Console.WriteLine("Wrong data!");
                data = 0;
            }

            return result;
        }
    }
}
