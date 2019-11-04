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
            IUserInterface gameInterface = new ConsoleInterface();

            gameInterface.WriteLine($"{Messages.EnterName}: ");
            var userName = gameInterface.ReadLine();

            var game = new Game(!string.IsNullOrEmpty(userName) ? userName : Messages.DefoultUserName);

            game.Field.Changed += (sender, eventArgs) =>
            {
                gameInterface.StartFromTop();
                gameInterface.WriteWithClearNextLine(game.Field);
                gameInterface.WriteWithClearNextLine(eventArgs.Message);
            };

            game.Field.Collapsed += (sender, eventArgs) => gameInterface.WriteWithClearNextLine(eventArgs.Message);

            gameInterface.StartFromTop();
            gameInterface.WriteWithClearNextLine(game.Field);

            do
            {
                game.Field.MovePerson((Direction)gameInterface.ReadKey().Key);
            } while (game.Person.IsAlive());

            Console.ReadKey();
        }
    }
}
