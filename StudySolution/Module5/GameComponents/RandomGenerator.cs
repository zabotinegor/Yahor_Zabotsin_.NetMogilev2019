using System;

namespace GameComponents
{
    static class RandomGenerator
    {
        private static Random random;
        static RandomGenerator()
        {
            Random = new Random(DateTime.Now.Ticks);
        }
    }
}
