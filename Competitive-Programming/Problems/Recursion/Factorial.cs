namespace Competitive_Programming.Problems.Recursion;

public static class Factorial
{
    //Given a non-negative integer, write a method that returns factorial of a number.
    //Expected input and output
    //Factorial(4) → 24
    //Factorial(7) → 5040

    public static long FactorialNumber(int num) => num == 0 || num == 1 ? 1 : num * FactorialNumber(num - 1);
}
