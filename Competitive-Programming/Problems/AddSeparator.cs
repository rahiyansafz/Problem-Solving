namespace Competitive_Programming.Problems;

public static class AddSeparator
{
    //Given a string and a separator, write a method that adds separator between each adjacent characters in a string.
    //Expected input and output
    //AddSeparator("ABCD", "^") → "A^B^C^D^"
    //AddSeparator("chocolate", "-") → "c-h-o-c-o-l-a-t-e"
    public static string Separator(string word, string separator)
    {
        string separatedWord = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();
        }

        return separatedWord;
    }
}
