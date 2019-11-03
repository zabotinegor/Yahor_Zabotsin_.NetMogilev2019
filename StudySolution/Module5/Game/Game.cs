using GameComponents;

namespace Game
{
    internal class Game
    {
        internal Field Field { get; private set; }

        internal Person Person { get;  }

        internal Game(string userName)
        {
            Person = new Person(userName);
            Field = new Field(10, 10, Person, 10);
        }

        internal void Restart()
        {
            Field = new Field(10, 10, Person, 10);
        }
    }
}
