namespace Random_Problems.Problems;

public static class RevertWordsOrder
{
    //Given a string, write a method that returns new string with reverted words order. Pay attention to the punctuation at the end of the sentence (period).
    //Expected input and output
    //RevertWordsOrder("John Doe.") → "Doe John."
    //RevertWordsOrder("A, B. C") → "C B. A,"

    public static string RevertWords(string str)
    {
        string[] strArray = str.Split(' ');
        int len = strArray.Length;

        for (int i = 0; i < len / 2; i++)
        {
            string temp = strArray[i];

            if (i == 0)
            {
                strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
                //strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);
                strArray[len - 1] = string.Concat(temp, strArray[len - 1].AsSpan(strArray[len - 1].Length - 1));
            }
            else
            {
                strArray[i] = strArray[len - 1 - i];
                strArray[len - 1 - i] = temp;
            }
        }

        return string.Join(" ", strArray);
    }
}
