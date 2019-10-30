using System;

namespace CustomMath
{
    public static class Roots
    {
        // решение уравнения F(x) = 0 на отрезке [a; b]
        // с точностью eps>0 методом деления отрезка пополам
        public static double Root(double a, double b, double eps, FunctionDelegate f)
        {
            // корень гарантировано существует,
            // если на концах отрезка
            // функция принимает значения различных знаков.
            if (f(a) * f(b) > 0)
                throw new Exception("Возможно, корней на этом отрезке не существует");
            // обеспечиваем выполнение условия:
            // a – левый конец отрезка, b – правый
            if (a > b)
            {
                double t = a;
                a = b;
                b = t;
            }
            // цикл метода деления отрезка пополам
            while (b - a > eps)
            {
                double c = (a + b) / 2;
                if (f(c) == 0)
                    return c;
                if (f(a) * f(c) < 0)
                    b = c;
                else
                    a = c;
            }
            return (a + b) / 2;
        }
    }
}
