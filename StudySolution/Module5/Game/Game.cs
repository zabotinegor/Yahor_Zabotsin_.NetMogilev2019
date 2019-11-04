using GameComponents;

namespace Game
{
    internal class Game
    {
        internal Field Field { get; private set; }

        internal Person Person { get;  }

        internal Game(string userName, bool mode)
        {
            Person = new Person(userName);
            Field = new Field(15, 10, Person, 10, mode);
        }

        internal void Restart(bool mode)
        {
            Person.Resurrection();
            Field = new Field(15, 10, Person, 10, mode);
        }
    }
}
