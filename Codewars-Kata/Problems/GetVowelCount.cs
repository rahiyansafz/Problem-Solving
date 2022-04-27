namespace Codewars_Kata.Problems;

internal class GetVowelCount
{
    public static int Solution(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}
