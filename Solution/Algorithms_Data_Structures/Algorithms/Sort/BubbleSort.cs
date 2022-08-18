using Algorithms_Data_Structures.Extensions;

namespace Algorithms_Data_Structures.Algorithms.Sort
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] input)
        {
            var length = input.Length;
            bool didSwap;

            do
            {
                didSwap = false;

                for (var i = 0; i < length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        input.SwapItems(i, i + 1);
                        didSwap = true;
                    }
                }
            } while (didSwap);

            return input; 
        }
    }
}
