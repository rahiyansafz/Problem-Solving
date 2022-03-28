namespace Competitive_Programming.Problems;

public static class CompressString
{
    //Given a non-empty string, write a method that returns it in compressed format.
    //Expected input and output
    //CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"
    //CompressString("p555ppp7www") → "p153p371w3"

    public static string StringCompressing(string str)
    {
        var count = 0;
        var last = str[0];
        var newStr = string.Empty;

        foreach (var s in str)
        {
            if (s == last)
            {
                count++;
            }
            else
            {
                newStr += last.ToString() + count;
                last = s;
                count = 1;
            }
        }

        newStr += last.ToString() + count;

        return newStr;
    }

}
