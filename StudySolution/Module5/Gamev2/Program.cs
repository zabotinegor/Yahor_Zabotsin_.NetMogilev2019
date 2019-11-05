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

            WriteLine("The player has 10 hit points.\n" +
                      "10 traps are randomly set on the field, the damage of which is determined randomly (from 1 to 10).\n" +
                      "Traps on the field are not visible, the player walks blindly. Does not go beyond the borders.\r\nGood luck.\n");
            WriteLine($"{SYMBOL_PERSON}- you\n" +
                      $"{SYMBOL_EXIT} - exit");
            //var currentCursorLine = 

            while (true)
            {

            }

            ReadKey();
        }
    }
}
