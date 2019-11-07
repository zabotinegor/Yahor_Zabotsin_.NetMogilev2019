using System;
using System.Collections.Generic;
using System.Text;
using static Gamev2.Resources.Resources;
using static System.Console;

namespace Gamev2
{
    class Program
    {
        private const int BORDER_WIDTH = 10;
        private const int BORDER_HEIGHT = 10;
        private const int BOMB_COUNT = 10;
        private const string GOD_MODE_KEY = "-g";

        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            bool godMode = (args.Length != 0) && args[0].Equals(GOD_MODE_KEY);
            IDictionary<(int x, int y), (bool active, int damage)> bombs;

            WriteLine(SuggestInputUserName);
            var userName = ReadLine();
            userName = string.IsNullOrEmpty(userName) ? DefaultName : userName;

            while (true)
            {
                #region Display rules

                Clear();
                WriteLine(godMode ? RulesForGodMode : Rules);
                WriteLine(string.Concat(PersonMarker, YouTitle, "\n", ExitSymbol, ExitTitle));

                var currentCursorLine = CursorTop;

                #endregion

                #region Generate session parameters

                int lifePoints = 10;
                var personCoordinates = (x: 0, y: 0);
                bombs = new Dictionary<(int x, int y), (bool active, int damage)>();

                GenerateBombs(bombs);

                #endregion

                do
                {

                    SetCursorPosition(0, currentCursorLine);

                    DisplayUserLife(userName, lifePoints);
                    DisplayGameField(personCoordinates, bombs, godMode);

                    MovePerson(ref personCoordinates);

                    CheckBombExplosion(personCoordinates, bombs, ref lifePoints, godMode);

                    #region End Session

                    if (lifePoints <= 0)
                    {
                        WriteMessageAndWait(MessageYouLose);
                        break;
                    }

                    if (personCoordinates == (BORDER_HEIGHT - 1, BORDER_WIDTH - 1))
                    {
                        WriteMessageAndWait(MessageYouWin);
                        break;
                    }

                    #endregion

                } while (true);

                #region Request to continue or exit

                Clear();
                WriteLine(MessageRequestToContinue);
                ConsoleKey answerKey;

                do
                {
                    ClearCurrentLine();
                    answerKey = ReadKey().Key;

                } while ((answerKey != ConsoleKey.Add) && (answerKey != ConsoleKey.Subtract));

                if (answerKey == ConsoleKey.Subtract)
                {
                    break;
                }

                #endregion
            }

            Clear();
            WriteMessageAndWait(MessageGameOver);
        }

        private static void DisplayUserLife(string userName, int lifePoints)
        {
            var personLife = string.Concat(userName, ": ");

            for (var i = 0; i < lifePoints; i++)
            {
                personLife = string.Concat(personLife, LifeSymbol);
            }

            RedrawCurrentLine(string.Concat(personLife, "\n"));
        }

        private static void CheckBombExplosion((int x, int y) personCoordinates,
                                                IDictionary<(int x, int y), (bool active, int damage)> bombs,
                                                ref int lifePoints,
                                                bool godMode)
        {
            ClearCurrentLine();

            if (bombs.TryGetValue(personCoordinates, out var bomb) && bomb.active)
            {
                lifePoints -= godMode ? 0 : bomb.damage;
                RedrawCurrentLine($"{MessageExplosion}  -{bomb.damage}");
                bombs.Remove(personCoordinates);
                bombs.Add(personCoordinates, (active: false, damage: 0));
            }
        }

        private static void DisplayGameField((int x, int y) personCoordinates,
                                                IDictionary<(int x, int y), (bool active, int damage)> bombs,
                                                bool godMode)
        {
            var field = string.Empty;

            for (var i = 0; i < BORDER_WIDTH; i++)
            {
                for (var j = 0; j < BORDER_HEIGHT; j++)
                {
                    var temp = ((j, i) == personCoordinates) ? PersonMarker :
                        (bombs.TryGetValue((j, i), out var bomb1) && !bomb1.active) ? BombSymbol :
                        (bombs.TryGetValue((j, i), out var bomb2) && godMode) ? string.Concat(bomb2.damage, " ") : CellSymbol;

                    field = string.Concat(field, ((i == BORDER_WIDTH - 1) && (j == BORDER_HEIGHT - 1)) ? ExitSymbol : temp);
                }

                field = string.Concat(field, "\n");
            }

            WriteLine(field);
        }

        private static void GenerateBombs(IDictionary<(int x, int y), (bool active, int damage)> bombs)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            for (var i = 0; i < BOMB_COUNT; i++)
            {
                (int x, int y) bombCoordinates;

                do
                {
                    bombCoordinates = (random.Next(0, BORDER_WIDTH - 1), random.Next(0, BORDER_HEIGHT - 1));

                } while (bombs.ContainsKey(bombCoordinates) || bombCoordinates == (0, 0) ||
                         bombCoordinates == (0, BORDER_HEIGHT - 1) || bombCoordinates == (0, BORDER_WIDTH - 1));

                bombs.Add(bombCoordinates, (true, random.Next(1, 10)));
            }
        }

        private static void MovePerson(ref (int x, int y) personCoordinates)
        {
            switch (ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    personCoordinates.y -= (personCoordinates.y > 0) ? 1 : 0;
                    break;
                case ConsoleKey.DownArrow:
                    personCoordinates.y += (personCoordinates.y < (BORDER_HEIGHT - 1)) ? 1 : 0;
                    break;
                case ConsoleKey.LeftArrow:
                    personCoordinates.x -= (personCoordinates.x > 0) ? 1 : 0;
                    break;
                case ConsoleKey.RightArrow:
                    personCoordinates.x += (personCoordinates.x < (BORDER_WIDTH - 1)) ? 1 : 0;
                    break;
            }
        }

        private static void ClearCurrentLine()
        {
            var currentLineCursor = CursorTop;

            SetCursorPosition(0, CursorTop);
            Write(new string(' ', WindowWidth));
            SetCursorPosition(0, currentLineCursor);
        }

        private static void RedrawCurrentLine(string str)
        {
            ClearCurrentLine();
            WriteLine(str);
        }

        private static void WriteMessageAndWait(string message)
        {
            WriteLine(message);
            ReadKey();
        }
    }
}
