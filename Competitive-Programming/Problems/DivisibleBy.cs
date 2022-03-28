namespace Competitive_Programming.Problems;

public static class DivisibleBy
{
    //Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
    //Expected input and output
    //DivisibleBy2Or3(15, 30) → 450
    //DivisibleBy2Or3(2, 90) → 180
    //DivisibleBy2Or3(7, 12) → 19

    public static int IsDivisible(int a, int b) => (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;

}
