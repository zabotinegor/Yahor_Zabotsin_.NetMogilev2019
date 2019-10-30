namespace CustomMath
{
    public static class Doubles
    {
        public static bool IsNegativeOrZero(this double number)
        {
            return number <= 0;
        }

        public static double Sum(double number1, double number2, double number3)
        {
            return number1 + number2 + number3;
        }
    }
}
