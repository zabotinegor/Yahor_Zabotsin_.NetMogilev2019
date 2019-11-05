using System;
using System.Collections;
using static System.Console;

namespace Gamev2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Game parameters
            var godMode = (args.Length != 0) && args[0].Equals("-g");
            var rightBorder = 10;
            var downBorder = 10;
            var bombCount = 10;
            IDictionary bombs;
            #endregion

            #region Symbols for display
            const string SYMBOL_PERSON = "@ ";
            const string SYMBOL_CELL = "X ";
            const string SYMBOL_EXIT = "E";
            const string SYMBOL_BOMB = "o "; 
            #endregion

            #region User
            WriteLine("Enter your name:");
            var userName = ReadLine();
            userName = string.IsNullOrEmpty(userName) ? "Player" : userName;
            var lifePoints = 10;
            Clear();
            #endregion

            #region Display rules
            WriteLine("The player has 10 hit points.\n" +
                          "10 traps are randomly set on the field, the damage of which is determined randomly (from 1 to 10).\n" +
                          "Traps on the field are not visible, the player walks blindly. Does not go beyond the borders.\r\nGood luck.\n");
            WriteLine($"{SYMBOL_PERSON}- you\n" +
                      $"{SYMBOL_EXIT} - exit");
            var currentCursorLine = CursorTop; 
            #endregion

            while (true)
            {

                #region MyRegion
                WriteLine("Would you like to continue? +/-");
                ConsoleKey answerKey;

                do
                {
                    var currentLineCursor = CursorTop;

                    SetCursorPosition(0, CursorTop);
                    Write(new string(' ', WindowWidth));
                    SetCursorPosition(0, currentLineCursor);

                    answerKey = ReadKey().Key;
                } while ((answerKey != ConsoleKey.Add) && (answerKey != ConsoleKey.Subtract));

                if (answerKey == ConsoleKey.Subtract)
                {
                    break;
                } 
                #endregion
            }

            Clear();
            WriteLine("Game over!");
            ReadKey();
        }
    }
}
