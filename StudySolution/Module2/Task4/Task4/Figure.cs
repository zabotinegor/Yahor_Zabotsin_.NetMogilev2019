namespace Task4
{
    internal abstract class Figure
    {
        protected double _demension;
        protected double Parameter
        {
            get => _demension;
            set => _demension = (value > 0) ? value : default;
        }
        internal abstract double Perimeter { get; }
        internal abstract double Area { get; }
        internal abstract double GetParameterByPerimeter(double perimeter);
        internal abstract double GetParameterByArea(double area);
    }
}
