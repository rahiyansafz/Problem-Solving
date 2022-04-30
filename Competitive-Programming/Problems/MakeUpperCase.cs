namespace Random_Problems.Problems;

public static class MakeUpperCase
{
    //Given a string, write a method that returns new string in which every odd letter of the word is uppercase. String may consist of one or more words.
    //Expected input and output
    //MakeUppercase("modem") → "MoDeM"
    //MakeUppercase("BookWorm") → "BoOkWoRm"
    //MakeUppercase("Aliquam dolor nisl?") → "AlIqUaM DoLoR NiSl?"

    public static string UpperCaseMaker(string word)
    {
        int letterIndex = 0;
        string uppercaseWord = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] >= 'a' && word[i] <= 'z' && letterIndex % 2 == 0)
            {
                letterIndex++;
                uppercaseWord += (char)(word[i] - 32);
            }
            else if (word[i] != ' ')
            {
                letterIndex++;
                uppercaseWord += word[i];
            }
            else
            {
                letterIndex = 0;
                uppercaseWord += word[i];
            }
        }
        return uppercaseWord;
    }
}
