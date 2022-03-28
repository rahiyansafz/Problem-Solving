namespace Competitive_Programming.Problems;

public static class ThreeIncreasingAdjacent
{
    //Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.
    //Expected input and output
    //ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True
    //ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False

    public static bool IsAdjacentToThree(int[] arr)
    {
        bool found = false;
        for (int i = 1; i <= arr.Length - 2; i++)
        {
            if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
            {
                found = true;
            }
        }

        return found;
    }
}
