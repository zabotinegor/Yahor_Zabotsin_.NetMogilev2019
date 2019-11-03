using Game.Resources;
using GameComponents.Enums;
using System;
using GameComponents;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(Messages.DefoultUserName);

            while (true)
            {
                //Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(game.Field);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        game.Field.MovePerson(Direction.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        game.Field.MovePerson(Direction.Down);
                        break;
                    case ConsoleKey.LeftArrow:
                        game.Field.MovePerson(Direction.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        game.Field.MovePerson(Direction.Right);
                        break;
                }

            }
        }
    }
}
