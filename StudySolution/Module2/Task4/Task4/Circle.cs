using System;

namespace Task4
{
    class Circle : Figure
    {
        private double _radius;
        public double Parameter
        {
            get => _radius;
            set => _radius = (value > 0) ? value : default;
        }

        public override double Perimeter => 2 * Math.PI * _radius;
        public override double Area => Math.PI * _radius * _radius;

        public Circle(double parameter)
        {
            Parameter = parameter;
        }
        public override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / (2 * Math.PI);
        }

        public override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area / Math.PI);
        }
    }
}
