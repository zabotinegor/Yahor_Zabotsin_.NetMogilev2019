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

        public void WriteWithClearNextLine<T>(T obj)
        {
            Console.WriteLine(obj);
            ClearLine();
        }

        public void ClearLine()
        {
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public void StartFromTop()
        {
            Console.SetCursorPosition(0, 0);
        }
    }
}
