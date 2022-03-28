namespace Competitive_Programming.Problems;

public static class FullSequenceOfLetters
{
    //Given a string of two letters, where first one occurs before the second in the alphabet, write a method that returns full sequence of letters starting from first and ending at the second one.
    //Expected input and output
    //FullSequenceOfLetters("ds") → "defghijklmnopqrs"
    //FullSequenceOfLetters("or") → "opqr"

    public static string SequenceOfFullLetters(string word)
    {
        string fullSequence = string.Empty;
        for (int i = word[0], j = 0; i <= word[1]; i++, j++)
        {
            fullSequence += (char)(word[0] + j);
        }

        return fullSequence;
    }
}
