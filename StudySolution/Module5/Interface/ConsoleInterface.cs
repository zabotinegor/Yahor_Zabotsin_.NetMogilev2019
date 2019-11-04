using System;

namespace Interfaces
{
    public class ConsoleInterface : IUserInterface
    {
        public void WriteLine<T>(T obj)
        {
            Console.WriteLine(obj);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void WriteWithClearLine<T>(T obj)
        {
            ClearCurrentConsoleLine();
            Console.WriteLine(obj);
        }

        public void ClearCurrentConsoleLine()
        {
            var currentLineCursor = Console.CursorTop;

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void ClearPreviousConsoleLine()
        {
            var currentLineCursor = Console.CursorTop;

            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void ClearNextConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void StartFromTop()
        {
            Console.SetCursorPosition(0, 0);
        }
    }
}
