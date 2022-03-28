namespace Competitive_Programming.Problems.Recursion;

public static class StringInReverseOrderRecursion
{
    //Given a string, write a method that prints it in reverse order.
    //Expected input and output
    //StringInReverseOrderRecursion("abcde") → "edcba"
    //StringInReverseOrderRecursion("Sed lectus est, elementum ut urna eu") → "ue anru tu mutnemele ,tse sutcel deS"

    //public static string StringInReverseOrderRecursion(string str) => str.Length > 0 ? str[str.Length - 1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
    //public static string StringInReverseOrderRecursion(string str) => str.Length > 0 ? str[^1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
    public static string RecursionStringInReverseOrder(string str) => str.Length > 0 ? str[^1] + RecursionStringInReverseOrder(str[0..^1]) : str;
}
