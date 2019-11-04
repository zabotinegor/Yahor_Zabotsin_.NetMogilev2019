namespace GameComponents
{
    public class Bomb : FieldObject
    {
        internal int Damage { get; }

        internal bool IsActive { get; private set; }

        public Bomb((int x, int y) coordinates) : base(coordinates)
        {
            Damage = RandomGenerator.GenerateInt(0, 10);
            IsActive = true;
        }

        internal override void Explode(int damage)
        {
            IsActive = false;
        }

        public override string ToString()
        {
            return IsActive ? $"{Resources.Dysplay.BombActive} " : $"{Resources.Dysplay.BombDeactive} ";
        }
    }
}
