using Game.Resources;
using GameComponents.Enums;
using System;
using Interfaces;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(Messages.DefoultUserName);
            game.Field.Changed += (sender, eventArgs) =>
            {
                ConsoleInterface.StartFromTop();
                ConsoleInterface.WriteWithClearNextLine(game.Field);
                ConsoleInterface.WriteWithClearNextLine(eventArgs.Message);
            };

            game.Field.Collapsed += (sender, eventArgs) =>
            {
                ConsoleInterface.WriteWithClearNextLine(eventArgs.Message);
            };

            ConsoleInterface.StartFromTop();
            ConsoleInterface.WriteWithClearNextLine(game.Field);

            while (true)
            {
                game.Field.MovePerson((Direction)Console.ReadKey().Key);
            }

        }
    }
}
