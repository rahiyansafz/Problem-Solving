using System.Numerics;

namespace Codewars_Kata.Problems;

//Adding Big Numbers
//    We need to sum big numbers and we require your help.

//    Write a function that returns the sum of two numbers.The input numbers are strings and the function must return a string.
//    Example

//    add("123", "321"); -> "444"
//    add("11", "99");   -> "110"

//    Notes
//    The input numbers are big.
//    The input is a string of only digits
//    The numbers are positives

internal class AddingBigNumbers
{
    public static string Add(string a, string b)
    {
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}


//Another Approach
//  public static string Add(string a, string b)
//{
//    BigInteger.TryParse(a, out var bigIntA);
//    BigInteger.TryParse(b, out var bigIntB);
//    return (bigIntA + bigIntB).ToString();
//}

// OR

//  public static string Add(string a, string b)
//{
//    return BigInteger.Add(BigInteger.Parse(a), BigInteger.Parse(b)).ToString();
//}