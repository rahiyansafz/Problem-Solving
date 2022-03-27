namespace Codewars_Kata.Problems;

internal class IsThisIsATriangle
{
    //## Is this a triangle? =>
    public static bool IsTriangle(int a, int b, int c) => a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    //{
    //    return a + b > c && b + c > a && a + c > b;
    //}
}
