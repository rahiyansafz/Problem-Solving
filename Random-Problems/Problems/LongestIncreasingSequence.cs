namespace Random_Problems.Problems;

public static class LongestIncreasingSequence
{
    //Given an array of integers, write a method that returns value of the longest strictly increasing sequence of numbers.
    //Expected input and output
    //LongestStrictlyIncreasingSequence([0, 3, 4, 5, 6, 4, 9]) → 3
    //LongestStrictlyIncreasingSequence([7, 7, 7, 7, 7]) → 0

    public static int IncreasingSequence(int[] array)
    {
        int tempLongest = 0;
        int longest = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                tempLongest++;
            }
            else
            {
                tempLongest = 0;
            }

            if (tempLongest > longest)
            {
                longest = tempLongest;
            }
        }

        return longest;
    }
}
