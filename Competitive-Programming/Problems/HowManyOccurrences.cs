namespace Random_Problems.Problems;

public static class HowManyOccurrences
{
    //Given a string and substring, write a method that returns number of occurrences of substring in the string. Assume that both are case-sensitive. You may need to use library function here.
    //Expected input and output
    //HowManyOccurrences("do it now", "do") → 1
    //HowManyOccurrences("empty", "d") → 0

    public static int Occurrences(string str, string subStr)
    {
        int found;
        int total = 0;
        for (int i = 0; i < str.Length; i++)
        {
            found = str.IndexOf(subStr, i);

            if (found > -1)
            {
                total++;
                i = found;
            }
        }

        return total;
    }
}
