namespace Random_Problems.Problems;

public static class IfSortedArray
{
    //Given an array of three integers, write a method that checks if they are sorted in ascending order.
    //Expected input and output
    //IfSortedAscending([3, 7, 10])→ true
    //IfSortedAscending([74, 62, 99])→ false

    public static bool IsSortedByAscending(int[] arr) => arr[0] <= arr[1] && arr[1] <= arr[2];
}
