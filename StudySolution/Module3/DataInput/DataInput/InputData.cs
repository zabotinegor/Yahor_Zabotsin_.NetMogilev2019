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
            firstData = default;
            secondData = default;
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
                    firstData = default;
                    secondData = default;
                }

            }
            else
            {
                Console.WriteLine("Wrong first one!");
                firstData = default;
                secondData = default;
            }

            return result;
        }

        public static bool NatData(string message, out int data)
        {
            data = default;
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
                    data = default;
                }
            }
            else
            {
                Console.WriteLine("Wrong data!");
                data = default;
            }

            return result;
        }
    }
}
