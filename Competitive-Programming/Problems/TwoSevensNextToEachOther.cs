namespace Competitive_Programming.Problems;

public static class TwoSevensNextToEachOther
{
    //Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
    //Expected input and output
    //Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 
    //Two7sNextToEachOther([9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]) → 3

    public static int IsNextToEachOther(int[] arr)
    {
        int adjacent7s = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 7 && arr[i + 1] == 7)
            {
                adjacent7s++;
            }
        }

        return adjacent7s;
    }
}
