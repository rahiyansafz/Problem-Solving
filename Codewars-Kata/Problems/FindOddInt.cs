namespace Codewars_Kata.Problems;

internal class FindOddInt
{
    //Find the odd int
    //Given an array, find the integer that appears an odd number of times.
    //There will always be only one integer that appears an odd number of times.

    //Examples

    //[7] should return 7, because it occurs 1 time(which is odd).
    //[0] should return 0, because it occurs 1 time(which is odd).
    //[1,1,2] should return 2, because it occurs 1 time(which is odd).
    //[0,1,0,1,0] should return 0, because it occurs 3 times(which is odd).
    //[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time(which is odd).
    //public static int find_it(int[] seq) => seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
    public static int FindIt(int[] seq) => seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;

    //return seq.Aggregate((a, b) => a ^ b);
}
