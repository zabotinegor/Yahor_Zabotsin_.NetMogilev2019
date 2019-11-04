namespace GameComponents
{
    public abstract class FieldObject
    {
        internal (int X, int Y) Coordinates { get; set; }

        protected FieldObject((int x, int y) coordinates)
        {
            Coordinates = coordinates;
        }

        internal abstract void Explode(int damage);

        public abstract override string ToString();
    }
}
