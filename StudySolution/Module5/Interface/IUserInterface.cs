using System;

namespace Interfaces
{
    public interface IUserInterface
    {
        void WriteLine<T>(T obj);

        string ReadLine();

        ConsoleKeyInfo ReadKey();

        void Clear();

        void WriteWithClearNextLine<T>(T obj);

        void ClearLine();

        void StartFromTop();
    }
}
