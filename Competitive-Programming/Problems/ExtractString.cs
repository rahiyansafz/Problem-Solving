namespace Competitive_Programming.Problems;

public static class ExtractString
{
    //Given a string, write a method that returns substring from between two double hash signs (#).
    //Expected input and output
    //ExtractString("##abc##def") → "abc"
    //ExtractString("12####78") → empty string
    //ExtractString("gar##d#en") → empty string
    //ExtractString("++##--##++") → "--"

    public static string ExtractingString(string word)
    {
        string extractedWord = string.Empty;

        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (word[i] == '#' && word[i + 1] == '#')
            {
                for (int j = i + 2; j <= word.Length - 1; j++)
                {
                    if (word[j] == '#' && word[j + 1] == '#')
                    {
                        return extractedWord;
                    }
                    extractedWord += word[j];
                }
            }
        }

        return string.Empty;
    }
}
