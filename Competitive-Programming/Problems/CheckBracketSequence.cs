namespace Competitive_Programming.Problems;

public static class CheckBracketSequence
{
    //Given a sequence of brackets, write a method that checks if it has the same number of opening and closing brackets.
    //Expected input and output
    //CheckBracketsSequence("((()))") → true
    //CheckBracketsSequence("()(())(") → false
    //CheckBracketsSequence(")") → false

    public static bool BracketsSequence(string sequence)
    {
        int check = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            check = sequence[i] == '(' ? ++check : --check;
        }

        return check == 0;
    }
}
