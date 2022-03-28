namespace Competitive_Programming.Problems;

public static class NumberOfWords
{
    //Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
    //Expected input and output
    //NumberOfWords("This is sample sentence") → 4
    //NumberOfWords("OK") → 1

    public static int NumOfWords(string str)
    {
        int numberOfWords = 0;
        for (int i = 1; i < str.Length; i++)
        {
            numberOfWords = (char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords);
        }

        return numberOfWords + 1;
    }
}
