using System.Linq;

namespace CustomMath
{
    public static class Arrays
    {
        public static bool Invert(ref int[] array)
        {
            if (array == null)
            {
                return false;
            }

            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }

            return true;
        }

        public static void FillHelix(ref int[,] array, int sizeY, int sizeX)
        {
            var sum = sizeX * sizeY;
            var correctY = 0;
            var correctX = 0;
            var startNumber = 1;

            while (sizeY > 0)
            {
                for (var side = 0; side < 4; side++)
                {
                    for (var x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
                    {
                        switch (side)
                        {
                            case 0 when (x < sizeX - correctX) && (startNumber <= sum):
                                array[side + correctY, x + correctX] = startNumber++;
                                break;
                            case 1 when (x < sizeY - correctY) && (x != 0) && (startNumber <= sum):
                                array[x + correctY, sizeX - 1] = startNumber++;
                                break;
                            case 2 when (x < sizeX - correctX) && (x != 0) && (startNumber <= sum):
                                array[sizeY - 1, sizeX - (x + 1)] = startNumber++;
                                break;
                            case 3 when (x < sizeY - (correctY + 1)) && (x != 0) && (startNumber <= sum):
                                array[sizeY - (x + 1), correctY] = startNumber++;
                                break;
                        }
                    }
                }

                sizeY--;
                sizeX--;
                correctY += 1;
                correctX += 1;
            }
        }
    }
}
