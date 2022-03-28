namespace Competitive_Programming.Problems;

public static class LettersBalance
{
    //Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string. Assume string length is even and letters don't repeat on each side.
    //Expected input and output
    //LettersBalance("fgvgvf") → true
    //LettersBalance("lampsmpser") → false

    public static bool BalanceOfLetters(string word)
    {
        bool isBalanced;
        for (int i = 0; i < word.Length / 2; i++)
        {
            isBalanced = false;
            for (int j = word.Length - 1; j >= word.Length / 2; j--)
            {
                if (word[i] == word[j])
                {
                    isBalanced = true;
                }
            }

            if (!isBalanced)
            {
                return false;
            }
        }

        return true;
    }
}
