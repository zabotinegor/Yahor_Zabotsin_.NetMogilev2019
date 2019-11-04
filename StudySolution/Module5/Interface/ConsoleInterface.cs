using System;

namespace Interfaces
{
    public static class ConsoleInterface
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void WriteWithClearNextLine<T>(T obj)
        {
            Console.WriteLine(obj);
            ClearLine();
        }

        public static void ClearLine()
        {
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public static void StartFromTop()
        {
            Console.SetCursorPosition(0, 0);
        }
    }
}
