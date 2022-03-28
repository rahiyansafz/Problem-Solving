namespace Competitive_Programming.Problems;

public static class SortCharactersDescending
{
    //Given a string, write a method that returns array of chars (ASCII characters) sorted in descending order.
    //Expected input and output
    //SortCharactersDescending("onomatopoeia") → tpoooonmieaa
    //SortCharactersDescending("fohjwf42os") → wsoojhff42

    public static char[] SortByDescending(string str)
    {
        char[] charArray = str.ToCharArray();
        char ch;

        for (int i = 1; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length - 1; j++)
            {
                if (charArray[j] < charArray[j + 1])
                {
                    ch = charArray[j];
                    charArray[j] = charArray[j + 1];
                    charArray[j + 1] = ch;
                }
            }
        }

        return charArray;
    }

}
