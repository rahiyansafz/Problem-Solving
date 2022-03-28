namespace Competitive_Programming.Problems;

public static class AbsoluteValue
{
    //Given an integer, write a method that returns its absolute value.
    //Expected input and output
    //AbsoluteValue(6832) → 6832
    //AbsoluteValue(-392) → 392

    public static int Absolute(int number) => number >= 0 ? number : number * -1;
}
