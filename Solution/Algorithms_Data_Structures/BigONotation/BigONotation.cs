namespace Algorithms_Data_Structures.BigONotation
{
    public static class BigONotation
    {
        // O(1) time
        public static int AccessingArrayIndex(int[] array, int index)
        {
            return array[index];
        }

        // O(n) time
        public static bool IsEqual(this string text1, string text2)
        {
            if (text1.Length != text2.Length)
            {
                return false;
            }

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] != text2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
