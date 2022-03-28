namespace Competitive_Programming.Problems.Recursion;

public static class ToThePowerOfRecursion
{
    //Given two integers, write a method that returns first number raised to the power of second number.
    //Expected input and output
    //ToThePowerOfRecursion(2, 3) → 8
    //ToThePowerOfRecursion(5, 2) → 25

    public static int RecursionPower(int b, int exp) => exp == 0 ? 1 : exp > 1 ? b * RecursionPower(b, exp - 1) : b;
}
