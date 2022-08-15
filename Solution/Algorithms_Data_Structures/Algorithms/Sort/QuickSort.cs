namespace Algorithms_Data_Structures.Algorithms.Sort
{
    public static class QuickSort
    {
        public static int[] Sort(int[] input)
        {
            if (input.Length <= 1)
            {
                return input;
            } 
            else if (input.Length == 2)
            {
                if (input[0] > input[1])
                {
                    SwapItems(input, 0, 1);
                }

                return input;
            }

            QuickSort(input);            

            return input;

            void QuickSort(int[] input)
            {
                var pivotIndex = SetPivot(input);

                var leftCursor = 0;
                var rightCursor = input.Length - 1;
                var done = false;

                while (!done)
                {
                    var movedCursor = false;

                    if ((leftCursor + 1) != pivotIndex &&
                        input[pivotIndex] >= input[leftCursor + 1])
                    {
                        movedCursor = true;
                        leftCursor ++;
                    }

                    if ((rightCursor - 1) != pivotIndex &&
                        input[pivotIndex] <= input[rightCursor - 1])
                    {
                        movedCursor = true;
                        rightCursor--;
                    }

                    if (!movedCursor)
                    {
                        if (leftCursor + 1 == pivotIndex)
                        {
                            pivotIndex = rightCursor - 1;
                        }

                        if (rightCursor - 1 == pivotIndex)
                        {
                            pivotIndex = leftCursor + 1;
                        }

                        SwapItems(input, leftCursor + 1, rightCursor - 1);
                    }

                    if (leftCursor + 1 == pivotIndex &&
                        rightCursor - 1 == pivotIndex)

                    {
                        done = true;
                    }
                }
            }

            int GetMiddleValue(int number)
            {
                return number % 2 == 0 ? number/2 : (number + 1)/2;
            }

            int SetPivot(int[] input)
            {
                var inputLength = input.Length;
                var middleIndex = GetMiddleValue(inputLength) - 1;

                var items = new Item[]
                {
                    new Item { Value = input[0], Index = 0},
                    new Item { Value = input[middleIndex], Index = middleIndex},
                    new Item { Value = input[inputLength - 1], Index = inputLength - 1}
                };

                var sortedItems = SelectionSort.Sort(items);

                input[0] = sortedItems[0].Value;
                input[middleIndex] = sortedItems[1].Value;
                input[inputLength - 1] = sortedItems[2].Value;

                return middleIndex;
            }

            void SwapItems(int[] input, int index1, int index2)
            {
                var copyOfValueFromIndex1 = input[index1];

                input[index1] = input[index2];
                input[index2] = copyOfValueFromIndex1;
            }
        }
    }
}
