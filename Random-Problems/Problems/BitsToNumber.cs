namespace Random_Problems.Problems;

public static class BitsToNumber
{
    //Write a method that takes non-empty string of bits as an argument and returns number as integer.
    //Expected input and output
    //BitsToNumber("1") → 1
    //BitsToNumber("100010") → 34

    public static int BitNumber(string bits)
    {
        var number = 0;

        for (var i = 0; i < bits.Length; i++)
        {
            number += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i - 1));
        }
        return number;
    }
}
