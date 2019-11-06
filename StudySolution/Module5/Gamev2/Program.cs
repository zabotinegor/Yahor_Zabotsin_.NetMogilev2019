using System;
using System.Collections.Generic;
using static System.Console;

namespace Gamev2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Game parameters
            bool godMode = (args.Length != 0) && args[0].Equals("-g");
            int rightBorder = 10;
            int downBorder = 10;
            int bombCount = 10;
            IDictionary<(int x, int y), (bool active, int damage)> bombs;
            Random random = new Random((int)DateTime.Now.Ticks);
            #endregion

            #region Symbols for display
            const string symbolPerson = "@ ";
            const string symbolCell = "X ";
            const string symbolExit = "E";
            const string symbolBomb = "o ";
            const string symbolLife = "* ";
            #endregion

            #region User
            WriteLine("Enter your name:");
            var userName = ReadLine();
            userName = string.IsNullOrEmpty(userName) ? "Player" : userName;
            #endregion

            #region Main loop
            while (true)
            {
                #region Display rules
                Clear();
                WriteLine("The player has 10 hit points.\n" +
                          "10 traps are randomly set on the field, the damage of which is determined randomly (from 1 to 10).\n" +
                          "Traps on the field are not visible, the player walks blindly. Does not go beyond the borders.\r\nGood luck.\n");
                WriteLine($"{symbolPerson}- you\n" +
                          $"{symbolExit}- exit");
                var currentCursorLine = CursorTop;
                #endregion

                #region Session parameters
                var lifePoints = 10;
                var personCoordinates = (x: 0, y: 0);
                bombs = new Dictionary<(int x, int y), (bool active, int damage)>();

                #region Generate bombs for session
                for (var i = 0; i < bombCount; i++)
                {
                    (int x, int y) bombCoordinates;

                    do
                    {
                        bombCoordinates = (random.Next(0, rightBorder - 1), random.Next(0, downBorder - 1));

                    } while (bombs.ContainsKey(bombCoordinates) || bombCoordinates == (0, 0) ||
                             bombCoordinates == (0, downBorder - 1) || bombCoordinates == (0, rightBorder - 1));

                    bombs.Add(bombCoordinates, (true, random.Next(1, 10)));
                }
                #endregion

                #endregion

                #region Game session loop
                do
                {
                    #region Display user life
                    var personLife = $"{userName}: ";

                    for (var i = 0; i < lifePoints; i++)
                    {
                        personLife = string.Concat(personLife, symbolLife);
                    }

                    personLife = $"{personLife}\n";
                    SetCursorPosition(0, currentCursorLine);
                    ClearCurrentConsoleLine();
                    WriteLine(personLife);
                    #endregion

                    #region Display game field
                    var field = string.Empty;

                    for (var i = 0; i < rightBorder; i++)
                    {
                        for (var j = 0; j < downBorder; j++)
                        {
                            var temp = ((j, i) == personCoordinates) ? symbolPerson :
                                (bombs.TryGetValue((j, i), out var bomb1) && !bomb1.active) ? symbolBomb :
                                (bombs.TryGetValue((j, i), out var bomb2) && godMode) ? $"{bomb2.damage} " : symbolCell;

                            field = string.Concat(field, ((i == rightBorder - 1) && (j == downBorder - 1)) ? symbolExit : temp);
                        }

                        field = $"{field}\n";
                    }

                    WriteLine(field);
                    #endregion

                    #region Move person
                    switch (ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            personCoordinates.y -= (personCoordinates.y > 0) ? 1 : 0;
                            break;
                        case ConsoleKey.DownArrow:
                            personCoordinates.y += (personCoordinates.y < (downBorder - 1)) ? 1 : 0;
                            break;
                        case ConsoleKey.LeftArrow:
                            personCoordinates.x -= (personCoordinates.x > 0) ? 1 : 0;
                            break;
                        case ConsoleKey.RightArrow:
                            personCoordinates.x += (personCoordinates.x < (rightBorder - 1)) ? 1 : 0;
                            break;
                        default:
                            continue;
                    }
                    #endregion

                    #region Person interaction with a bomb
                    ClearCurrentConsoleLine();
                    if (bombs.TryGetValue(personCoordinates, out var bomb) && bomb.active)
                    {
                        lifePoints -= godMode ? 0 : bomb.damage;
                        ClearCurrentConsoleLine();
                        WriteLine($"Boom!  -{bomb.damage}");
                        bombs.Remove(personCoordinates);
                        bombs.Add(personCoordinates, (active: false, damage: 0));
                    }
                    #endregion

                    #region End Session
                    if (lifePoints <= 0)
                    {
                        WriteLine("You lose!");
                        ReadKey();
                        break;
                    }

                    if (personCoordinates == (downBorder - 1, rightBorder - 1))
                    {
                        WriteLine("You win!");
                        ReadKey();
                        break;
                    }
                    #endregion

                } while (true);
                #endregion

                #region Request to continue or exit
                Clear();
                WriteLine("Would you like to continue? +/-");
                ConsoleKey answerKey;

                do
                {
                    ClearCurrentConsoleLine();
                    answerKey = ReadKey().Key;

                } while ((answerKey != ConsoleKey.Add) && (answerKey != ConsoleKey.Subtract));

                if (answerKey == ConsoleKey.Subtract)
                {
                    break;
                }
                #endregion
            }
            #endregion

            Clear();
            WriteLine("Game over!");
            ReadKey();
        }

        private static void ClearCurrentConsoleLine()
        {
            var currentLineCursor = CursorTop;

            SetCursorPosition(0, CursorTop);
            Write(new string(' ', WindowWidth));
            SetCursorPosition(0, currentLineCursor);
        }
    }
}
