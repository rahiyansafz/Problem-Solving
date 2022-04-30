namespace Random_Problems.Problems;

public static class LengthOfString
{
    //Given a string, write a method that returns its length. Do not use library methods!
    //Expected input and output
    //LengthOfAString("computer") → 8
    //LengthOfAString("ice cream") → 9

    public static int StringLength(string str)
    {
        int length = 0;
        foreach (char c in str)
        {
            length++;
        }

        return length;
    }
}
