using System;

namespace Task4
{
    internal class Circle : Figure
    {
        internal override double Perimeter => 2 * Math.PI * _demension;
        internal override double Area => Math.PI * Math.Pow(_demension, 2);

        public Circle(double parameter)
        {
            Parameter = parameter;
        }

        internal override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / (2 * Math.PI);
        }

        internal override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area / Math.PI);
        }
    }
}
