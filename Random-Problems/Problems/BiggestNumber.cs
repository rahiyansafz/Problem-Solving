namespace Random_Problems.Problems;

public static class BiggestNumber
{
    public static int TheBiggestNumber(int[] numArr)
    {
        int theBiggest = numArr[0];

        for (int i = 1; i < numArr.Length; i++)
        {
            if (numArr[i] > theBiggest)
            {
                theBiggest = numArr[i];
            }
        }

        return theBiggest;
    }
}
