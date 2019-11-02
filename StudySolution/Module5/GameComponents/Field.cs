using System;
using System.Collections.Generic;
using GameComponents.Enums;

namespace GameComponents
{
    public class Field
    {
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

        public void Move(FieldObject fieldObject, Direction direction)
        {
            var coordinates = fieldObject.Coordinates;

            switch (direction)
            {
                case Direction.Up:
                    fieldObject.Coordinates = (coordinates.X, coordinates.Y + 1);
                    break;
                case Direction.Down:
                    fieldObject.Coordinates = (coordinates.X, coordinates.Y - 1);
                    break;
                case Direction.Left:
                    fieldObject.Coordinates = (coordinates.X - 1, coordinates.Y);
                    break;
                case Direction.Right:
                    fieldObject.Coordinates = (coordinates.X + 1, coordinates.Y);
                    break;default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}