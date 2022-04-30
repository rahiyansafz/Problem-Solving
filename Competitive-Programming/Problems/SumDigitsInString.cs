namespace Random_Problems.Problems;

public static class SumDigitsInString
{
    //Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
    //Expected input and output
    //SumDigitsInString("1q2w3e") → 6
    //SumDigitsInString("L0r3m.1p5um") → 9
    //SumDigitsInString("") → 0

    public static int SumOfStringDigit(string str)
    {
        var sum = 0;

        for (var i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                sum += (int)char.GetNumericValue(str[i]);
            }
        }

        return sum;
    }
}
