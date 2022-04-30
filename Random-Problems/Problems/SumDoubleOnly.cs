namespace Random_Problems.Problems;

public static class SumDoubleOnly
{
    //Given an array of objects, write a method that returns sum of objects of double type.
    //Expected input and output
    //SumDoubleOnly(["abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22]) → 7.82

    public static double DoubleSum(object[] obj)
    {
        double sum = 0.0;
        for (int i = 0; i < obj.Length; i++)
        {
            //if (obj[i] is double)
            //{
            //    sum += (double)obj[i];
            //}
            if (obj[i] is double @double)
            {
                sum += @double;
            }
        }

        return sum;
    }
}
