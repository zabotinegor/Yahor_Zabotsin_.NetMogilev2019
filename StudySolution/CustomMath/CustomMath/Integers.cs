namespace CustomMath
{
    public static class Integers
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsNatural(this int number)
        {
            return number > 0;
        }

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public static void IncreaseBy10(ref int number1, ref int number2, ref int number3)
        {
            number1 += 10;
            number2 += 10;
            number3 += 10;
        }

        public static (int number1, int number2, int number3) IncreaseBy10(int number1, int number2, int number3)
        {
            return (number1 + 10, number2 + 10, number3 + 10);
        }
    }
}
