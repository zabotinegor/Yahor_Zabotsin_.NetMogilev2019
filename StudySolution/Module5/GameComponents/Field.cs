using GameComponents.Enums;
using System;
using System.Collections.Generic;

namespace GameComponents
{
    public class Field
    {
        public event FieldStateHandler Changed;

        public event FieldStateHandler Collapsed;

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
                var bomb = new Bomb((RandomGenerator.GenerateInt(0, width - 1), RandomGenerator.GenerateInt(0, height - 1)));

                while (bombCount < ((height * width) - 2))
                {
                    if (!Bombs.ContainsKey(bomb.Coordinates) && CheckBombCoordinates(bomb.Coordinates))
                    {
                        Bombs.Add(bomb.Coordinates, bomb);
                        break;
                    }
                    else
                    {
                        bomb.Coordinates = (RandomGenerator.GenerateInt(0, width - 1), RandomGenerator.GenerateInt(0, height - 1));
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

            OnChanged(new FieldEventArgs(Person.ToString(true)));

            if (Bombs.TryGetValue((Person.Coordinates), out var bomb) && bomb.IsActive)
            {
                Person.Explode(bomb.Damage);
                bomb.Explode(bomb.Damage);
                Bombs.Remove(bomb.Coordinates);
                Bombs.Add(bomb.Coordinates, bomb);
                OnCollapsed(new FieldEventArgs(string.Concat(Resources.Dysplay.Bang, $" -{bomb.Damage}")));
            }
        }

        private bool CheckBombCoordinates((int, int) coordinates)
        {
            return coordinates != (0, 0) && coordinates != (Width - 1, Height - 1);
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

        protected virtual void OnCollapsed(FieldEventArgs e)
        {
            CallEvent(e, Collapsed);
        }

        public override string ToString()
        {
            var result = string.Empty;

            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    var temp = ((j, i) == Person.Coordinates) ? Person.ToString() :
                        Bombs.TryGetValue((j, i), out var bomb) ? bomb.ToString() : $"{Resources.Dysplay.Cell} ";

                    result = string.Concat(result, temp);
                }

                result = string.Concat(result, "\n");
            }

            return result;
        }
    }
}