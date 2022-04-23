﻿namespace Codewars_Kata.Problems;

internal class IsThisIsATriangle
{
    //## Is this a triangle? =>
    //Implement a function that accepts 3 integer values a, b, c.The function should return true if a triangle can be built with the sides of given length and false in any other case.

    //(In this case, all triangles must have surface greater than 0 to be accepted).

    public static bool IsTriangle(int a, int b, int c) => a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    //{
    //    return a + b > c && b + c > a && a + c > b;
    //}
}
