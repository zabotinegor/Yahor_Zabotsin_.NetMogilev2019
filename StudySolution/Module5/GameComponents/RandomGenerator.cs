using System;

namespace GameComponents
{
    internal static class RandomGenerator
    {
        private static readonly Random Random;
        static RandomGenerator()
        {
            Random = new Random((int) DateTime.Now.Ticks);
        }

        public static int GenerateInt(int min = int.MinValue, int max = int.MaxValue)
        {
            return Random.Next(min, max);
        }

        public static double GenerateDouble()
        {
            return Random.NextDouble();
        }
    }
}
