namespace Codewars_Kata.Problems;

internal class YourOrderPlease
{
    //## Your order, please =>
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words)) return words;
        return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
    }
}
