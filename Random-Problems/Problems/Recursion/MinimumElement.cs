namespace Random_Problems.Problems.Recursion;

public static class MinimumElement
{
    //Given an array of integers and array's length, write a method that returns its minimum element.
    //Expected input and output
    //MinimumElement([8, 5, 9], 3) → 5
    //MinimumElement([-2, -9, 2, -3, 1, 0], 6) → -9

    public static int MinElement(int[] arr, int size)
    {
        if (size == 1)
        {
            return arr[0];
        }

        return arr[size - 1] < MinElement(arr, size - 1) ? arr[size - 1] : MinElement(arr, size - 1);
    }
}
