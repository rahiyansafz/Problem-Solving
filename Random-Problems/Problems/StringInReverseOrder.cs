namespace Random_Problems.Problems;

public static class StringInReverseOrder
{
    //Given a string, write a method that returns that string in reverse order.
    //Expected input and output
    //StringInReverseOrder("qwerty") → "ytrewq"
    //StringInReverseOrder("oe93 kr") → "rk 39eo"

    public static string ReverseOrderString(string str)
    {
        string reverseString = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverseString += str[i];
        }

        return reverseString;
    }
}
