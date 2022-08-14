using System.Collections.Generic;

namespace Algorithms_Data_Structures.DataStructures.Selection_Sort_Algorithm
{
    public static class SortAlgorithms
    {
        public static int[] SelectionSort(int[] input)
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
                    if (inputAsList[i] < inputAsList[i - 1])
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
