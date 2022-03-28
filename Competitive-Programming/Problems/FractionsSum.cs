namespace Competitive_Programming.Problems;

public static class FractionsSum
{
    //Given an integer n, write a method that returns sum of series 1 + (½)² +(⅓)² +... +(1⁄n)². Do not use library function!
    //Expected input and output
    //FractionsSum(3) → 1.36111111111111
    //FractionsSum(5) → 1.46361111111111

    public static double FractedSum(int num)
    {
        double sum = 0.0;
        for (int i = 1; i <= num; i++)
        {
            sum += (1 / (double)(i * i));
        }

        return sum;
    }
}
