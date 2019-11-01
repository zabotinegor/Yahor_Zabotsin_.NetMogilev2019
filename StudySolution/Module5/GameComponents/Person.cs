namespace GameComponents
{
    internal class Person : FieldObject
    {

        private int live;

        protected string Name { get; }

        protected internal int Live
        {
            get => live;

            private set => live = (value < 0) ? 0 : value;
        }

        protected bool IsAlive() => (Live > 0);

        protected Person(string name, (int x, int y) coordinates) : base(coordinates)
        {
            Name = name;
            Live = 10;
        }

        protected override void Explode(int damage)
        {
            Live -= damage;
        }
    }
}
