namespace Random_Problems.Problems;

public static class MixTwoStrings
{
    //Given two strings, write a method that returns one string made of two strings. First letter of new string is first letter of first string, second letter of new string is first letter of second string and so on.
    //Expected input and output
    //MixTwoStrings("aaa", "BBB") → "aBaBaB"
    //MixTwoStrings("good one", "111") → "g1o1o1d one"

    public static string StringMixer(string word1, string word2)
    {
        string mixedWord = string.Empty;

        for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
        {
            if (i < word1.Length)
            {
                mixedWord += word1[i];
            }
            if (i < word2.Length)
            {
                mixedWord += word2[i];
            }
        }

        return mixedWord;
    }
}
