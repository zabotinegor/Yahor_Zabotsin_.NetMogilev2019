using GameComponents.Enums;
using System;
using System.Collections.Generic;

namespace GameComponents
{
    public class Field
    {
        public event FieldStateHandler Changed;

        protected int Width { get; }

        protected int Height { get; }

        protected Person Person { get; }

        protected IDictionary<ValueTuple<int, int>, Bomb> Bombs { get; }

        public Field(int width, int height, Person person, int bombCount)
        {
            Width = width;
            Height = height;
            Person = person;

            Bombs = new Dictionary<(int, int), Bomb>();

            for (var i = 0; i < bombCount; i++)
            {
                var bomb = new Bomb((RandomGenerator.GenerateInt(0, width), RandomGenerator.GenerateInt(0, height)));

                while (bombCount < height * width)
                {
                    if (!Bombs.ContainsKey(bomb.Coordinates))
                    {
                        Bombs.Add(bomb.Coordinates, bomb);
                        break;
                    }
                    else
                    {
                        bomb.Coordinates = (RandomGenerator.GenerateInt(0, width), RandomGenerator.GenerateInt(0, height));
                    }
                }
            }
        }

        public void MovePerson(Direction direction)
        {
            var coordinates = Person.Coordinates;

            switch (direction)
            {
                case Direction.Up:
                    Person.Coordinates = (coordinates.Y > 0) ? (coordinates.X, coordinates.Y - 1) : coordinates;
                    break;
                case Direction.Down:
                    Person.Coordinates = (coordinates.Y < Height - 1) ? (coordinates.X, coordinates.Y + 1) : coordinates;
                    break;
                case Direction.Left:
                    Person.Coordinates = (coordinates.X > 0) ? (coordinates.X - 1, coordinates.Y) : coordinates;
                    break;
                case Direction.Right:
                    Person.Coordinates = (coordinates.X < Width - 1) ? (coordinates.X + 1, coordinates.Y) : coordinates;
                    break;
            }
            OnChanged(new FieldEventArgs(Person.Name));
        }

        private void CallEvent(FieldEventArgs e, FieldStateHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }

        protected virtual void OnChanged(FieldEventArgs e)
        {
            CallEvent(e, Changed);
        }

        public override string ToString()
        {
            var result = string.Empty;

            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    var temp = ((j, i) == Person.Coordinates) ? Person.ToString() :
                        Bombs.TryGetValue((j, i), out var bomb) ? bomb.ToString() : "X ";

                    result = string.Concat(result, temp);
                }

                result = string.Concat(result, "\n");
            }

            result = string.Concat(result, "\n");

            return result;
        }
    }
}