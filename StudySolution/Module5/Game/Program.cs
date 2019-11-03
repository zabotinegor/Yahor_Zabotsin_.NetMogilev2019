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

            while (true)
            {
                //Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(game.Field);

                game.Field.MovePerson((Direction)Console.ReadKey().Key);
            }

        }
    }
}
