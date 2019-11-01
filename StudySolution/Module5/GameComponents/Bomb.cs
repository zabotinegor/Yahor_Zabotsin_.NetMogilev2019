namespace GameComponents
{
    internal class Bomb : FieldObject
    {
        protected int Damage { get; }

        protected bool IsActive { get; private set; }

        protected Bomb((int x, int y) coordinates) : base(coordinates)
        {
            Damage = RandomGenerator.GenerateInt(0, 10);
            IsActive = true;
        }

        protected override void Explode(int damage)
        {
            IsActive = false;
        }
    }
}
