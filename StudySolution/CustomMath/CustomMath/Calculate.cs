using System;

namespace CustomMath
{
    public enum Operations
    {
        Sum,
        Dif,
        Div,
        Mul
    }

    public static class Calculate
    {
        public static double Calculation(double a, double b, Operations operation)
        {
            switch (operation)
            {
                case Operations.Sum:
                    return a + b;
                case Operations.Dif:
                    return a - b;
                case Operations.Div:
                    if (b == 0d)
                    {
                        throw new DivideByZeroException($"{nameof(b)} is 0");
                    }

                    return  a / b;
                case Operations.Mul:
                    return a * b;

                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
