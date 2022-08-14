using System.Collections.Generic;

namespace Algorithms_Data_Structures.DataStructures.Selection_Sort_Algorithm
{
    public static class SortAlgorithms
    {
        public static int[] SelectionSort(int[] input)
        {
            var inputLength = input.Length;
            var currentPosition = 0;

            while (currentPosition < inputLength - 1)
            {
                var currentIndex = currentPosition;
                var currentMinValue = input[currentIndex];

                for (int i = currentPosition + 1; i < input.Length; i++)
                {
                    if (input[i] < currentMinValue)
                    {
                        currentMinValue = input[i];
                        currentIndex = i;
                    }
                }

                input[currentIndex] = input[currentPosition];
                input[currentPosition] = currentMinValue;

                currentPosition++;
            }

            return input;
        }

        public static int[] SelectionSort_Solution2(int[] input)
        {
            var inputAsList = new List<int>(input);
            var inputLength = input.Length;
            var result = new int[inputLength];
            var currentPosition = 0;            

            while (currentPosition < inputLength)
            {
                var currentIndex = 0;
                var currentMinValue = inputAsList[currentIndex];                

                for (int i = 1; i < inputAsList.Count; i++)
                {
                    if (inputAsList[i] < currentMinValue)
                    {
                        currentMinValue = inputAsList[i];
                        currentIndex = i;
                    }
                }

                result[currentPosition] = currentMinValue;
                inputAsList.RemoveAt(currentIndex);
                currentPosition++;
            }            

            return result;
        }
    }
}
