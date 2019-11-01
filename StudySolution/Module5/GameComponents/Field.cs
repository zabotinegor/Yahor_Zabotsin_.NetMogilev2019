using System.Collections.Generic;

namespace GameComponents
{
    internal class Field
    {
        protected int Width { get; }

        protected int Height { get; }

        protected Person Person { get; }

        protected IEnumerable<Bomb> Bombs { get; }

        protected Field(int width, int height, IEnumerable<Bomb> bombs, Person person)
        {
            Width = width;
            Height = height;
            Bombs = bombs;
            Person = person;
        }
    }
}