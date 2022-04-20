﻿namespace Codewars_Kata.Problems;

internal class MultiplesOf3Or5
{
    //Multiples of 3 or 5

    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
    //Note: If the number is a multiple of both 3 and 5, only count it once.
    public static int Solution(int n) => Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
    //return Enumerable.Range(0, value).Sum(n => n % 3 == 0 || n % 5 == 0 ? n : 0);
}
