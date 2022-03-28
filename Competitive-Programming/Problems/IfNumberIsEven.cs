namespace Competitive_Programming.Problems;

public static class IfNumberIsEven
{
    //Given an integer, write a method that checks if it is even.
    //Expected input and output
    //IfNumberIsEven(721) → false
    //IfNumberIsEven(1248) → true

    public static bool IsNumberEven(int num) => num % 2 == 0;
}
