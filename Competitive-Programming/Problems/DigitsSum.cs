namespace Competitive_Programming.Problems;

public static class DigitsSum
{
    //Given a non-negative number, write a method that returns sum of its digits.
    //Expected input and output
    //DigitsSum(5434) → 16
    //DigitsSum(904861) → 28

    public static int SumOfDigit(uint number)
    {
        int sum = 0;
        int i = 10;
        int j = 1;

        while (number / j >= 1)
        {
            sum += (int)(number % i / j);

            i *= 10;
            j *= 10;
        }

        return sum;
    }
}
