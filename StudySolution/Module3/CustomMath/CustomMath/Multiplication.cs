namespace CustomMath
{
    public static class Multiplication
    {
        public static int AdditionMultiplication(int firstMultiplier, int secondMultiplier)
        {
            var result = 0;

            if ((firstMultiplier < 0) && (secondMultiplier < 0))
            {
                firstMultiplier = -firstMultiplier;
                secondMultiplier = -secondMultiplier;
            }

            if (secondMultiplier >= 0)
            {
                while (secondMultiplier != 0)
                {
                    if ((secondMultiplier & 1) == 1)
                    {
                        result += firstMultiplier;
                    }

                    firstMultiplier += firstMultiplier;
                    secondMultiplier /= 2;
                }
            }
            else if (firstMultiplier >= 0)
            {
                while (firstMultiplier != 0)
                {
                    if ((firstMultiplier & 1) == 1)
                    {
                        result += secondMultiplier;
                    }

                    secondMultiplier += secondMultiplier;
                    firstMultiplier /= 2;
                }
            }

            return result;
        }
    }
}
