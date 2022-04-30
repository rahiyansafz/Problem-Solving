namespace Random_Problems.Problems;

public static class ReplaceTwoWords
{
    //Given a string in which two words are separated by a char, write a method that replaces these two words.
    //Expected input and output
    //ReplaceWords("abc_xyz", '_') → xyz_abc
    //ReplaceWords("trolling.master", '.') → master.trolling

    public static string WordReplacing(string word, char ch)
    {
        string firstWord = string.Empty;
        string secondWord = string.Empty;

        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (word[i] != ch)
            {
                secondWord += word[i];
            }
            else
            {
                for (int j = i + 1; j <= word.Length - 1; j++)
                {
                    firstWord += word[j];
                }
                break;
            }
        }

        return firstWord + ch + secondWord;
    }

}
