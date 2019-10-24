namespace CustomMath
{
    public static class Doubles
    {
        public static double Sum(double number1, double number2, double number3)
        {
            return number1 + number2 + number3;
        }

        public static void IncreaseBy10(ref double number1, ref double number2, ref double number3)
        {
            number1 += 10;
            number2 += 10;
            number3 += 10;
        }
    }
}
