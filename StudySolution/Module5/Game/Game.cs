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
            Field = new Field(15, 10, Person, 10);
        }

        internal void Restart()
        {
            Person.Resurrection();
            Field = new Field(15, 10, Person, 10);
        }
    }
}
