using Game.Resources;
using GameComponents.Enums;
using Interfaces;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInterface gameInterface = new ConsoleInterface();

            gameInterface.WriteLine($"{Messages.EnterName}: ");

            var userName = gameInterface.ReadLine();

            #region GameInitialization
            var game = new Game(!string.IsNullOrEmpty(userName) ? userName : Messages.DefoultUserName);
            #endregion

            while (true)
            {
                #region FieldEventsInitialization
                game.Field.Changed += (sender, eventArgs) =>
                        {
                            gameInterface.StartFromTop();
                            gameInterface.WriteWithClearLine(game.Field);
                            gameInterface.ClearPreviousConsoleLine();

                            gameInterface.WriteWithClearLine(eventArgs.Message);
                            gameInterface.ClearCurrentConsoleLine();
                            gameInterface.ClearNextConsoleLine();
                        };
                game.Field.Collapsed += (sender, eventArgs) =>
                {
                    gameInterface.WriteWithClearLine(eventArgs.Message);
                    gameInterface.ClearCurrentConsoleLine();
                };
                game.Field.Released += (sender, eventArgs) =>
                {
                    gameInterface.Clear();
                    gameInterface.WriteLine(Resources.Messages.YouWin);
                };
                #endregion

                #region StartDisplay
                gameInterface.Clear();
                gameInterface.WriteLine($"{game.Person.Name}");
                gameInterface.WriteLine($"{game.Person.ToString()} - {Resources.Messages.You}");
                gameInterface.WriteLine($"{GameComponents.Resources.Dysplay.Exit} - {Resources.Messages.Exit}\n");
                gameInterface.WriteLine(game.Field); 
                #endregion

                do
                {
                    game.Field.MovePerson((Direction)gameInterface.ReadKey().Key);
                } while (game.Person.IsAlive());

                Console.WriteLine(Resources.Messages.RequestToContinue);
                ConsoleKey answer;

                do
                {
                    gameInterface.ClearCurrentConsoleLine();
                    answer = Console.ReadKey().Key;
                } while ((answer != ConsoleKey.Add) && (answer != ConsoleKey.Subtract));

                if (answer == ConsoleKey.Subtract)
                {
                    break;
                }
                else
                {
                    game.Restart();
                }
            }

            Console.ReadKey();
        }
    }
}
