namespace GameComponents
{
    public class Person : FieldObject
    {

        private int live;

        public string Name { get; }

        protected internal int Live
        {
            get => live;

            private set => live = (value < 0) ? 0 : value;
        }

        public bool IsAlive() => (Live > 0);

        public void Resurrection()
        {
            Live = 10;
            Coordinates = (0, 0);
        }

        public Person(string name, (int x, int y) coordinates) : base(coordinates)
        {
            Name = name;
            Live = 10;
        }

        public Person(string name) : this(name, (0, 0))
        {
        }

        internal override void Explode(int damage)
        {
            Live -= damage;
        }

        public override string ToString()
        {
            return $"{Resources.Dysplay.Person} ";
        }

        public string ToString(bool showLive)
        {
            var result = string.Concat(Name, ": ");

            if (showLive)
            {
                for (var i = 1; i <= this.live; i++)
                {
                    result = string.Concat(result, $"{i} ");
                }
            }

            return result;
        }
    }
}
