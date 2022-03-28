namespace Competitive_Programming.Problems.Recursion;

public static class RecursionPalindrome
{
    //Given a string, write a method that checks if it is a palindrome. String length may be >= 0.
    //Expected input and output
    //IsPalindromeRecursion("xx") → true
    //IsPalindromeRecursion("pendrive") → false

    public static bool IsPalindromeRecursion(string str)
    {
        if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
        {
            return true;
        }
        else if (str.Length > 1)
        {
            //if (str[0] != str[str.Length - 1])
            if (str[0] != str[^1])
            {
                return false;
            }

            //return IsPalindromeRecursion(str.Substring(1, str.Length - 2));
            return IsPalindromeRecursion(str[1..^1]);
        }

        return false;
    }
}
