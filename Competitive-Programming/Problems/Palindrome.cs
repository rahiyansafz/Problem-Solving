namespace Competitive_Programming.Problems;

public static class Palindrome
{
    //Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.
    //Expected input and output
    //IsPalindrome("eye") → true
    //IsPalindrome("home") → false

    public static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

}
