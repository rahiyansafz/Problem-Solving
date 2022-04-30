namespace Random_Problems.Problems;

public static class SumAndAverage
{
    //Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m].
    //Expected input and output
    //SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5"
    //SumAndAverage(-10, 0) → "Sum: -55, Average: -5"

    public static string SummationAndAverage(int lowest, int highest)
    {
        int sum = 0;
        int range = 0;
        for (int i = lowest; i <= highest; i++)
        {
            sum += i;
            range++;
        }

        double average = sum / (double)range;

        return string.Format($"Sum: {sum}, Average: {average}");
    }
}
