namespace Codewars_Kata.Problems;

internal class ArrayDiff
{
    public static int[] ArrayDiffCP(int[] a, int[] b)
    {
        //return Array.FindAll(a, m => !b.Contains(m));
        return a.Where(n => !b.Contains(n)).ToArray();
    }
}
