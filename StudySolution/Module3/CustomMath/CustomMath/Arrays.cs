namespace CustomMath
{
    public static class Arrays
    {
        public static bool Invert(ref int[] array)
        {
            if (array == null) return false;

            for (var i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }

            return true;
        }
    }
}
