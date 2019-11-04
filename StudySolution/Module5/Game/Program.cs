using Game.Resources;
using GameComponents.Enums;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(Messages.DefoultUserName);
            game.Field.Changed += (sender, eventArgs) =>
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(game.Field);
                Console.WriteLine(eventArgs.Message);
            };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(game.Field);

            while (true)
            {
                game.Field.MovePerson((Direction)Console.ReadKey().Key);
            }

        }
    }
}
