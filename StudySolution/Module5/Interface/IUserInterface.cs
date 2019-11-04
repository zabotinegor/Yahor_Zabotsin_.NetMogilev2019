using System;

namespace Interfaces
{
    public interface IUserInterface
    {
        void WriteLine<T>(T obj);

        string ReadLine();

        ConsoleKeyInfo ReadKey();

        void Clear();

        void WriteWithClearLine<T>(T obj);

        void ClearCurrentConsoleLine();

        void ClearPreviousConsoleLine();

        void ClearNextConsoleLine();

        void StartFromTop();
    }
}
