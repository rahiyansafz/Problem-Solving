namespace Competitive_Programming.Problems;

public static class SortArrayAscending
{
    //Given an array of integers, write a method that returns sorted array in ascending order.
    //Expected input and output
    //SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9] 

    public static int[] AscendingSortedArray(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        return arr;
    }
}
