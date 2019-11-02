using System;
using  Game.Resources;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(Messages.DefoultUserName);

            Console.ReadKey();
        }
    }
}
