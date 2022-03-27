namespace Codewars_Kata.Problems;

internal class ASquareOfSquares
{
    //## A square of squares =>
    public static bool IsSquare(int n)
    {
        //var numCheck = (Math.Sqrt(n) % 1) == 0;
        return ((Math.Sqrt(n) % 1) == 0);
    }
}
