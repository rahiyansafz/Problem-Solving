using System.Text.RegularExpressions;

namespace Codewars_Kata.Problems;

internal class CountSmileyFaces
{
    //## Count the smiley faces!
    public static int CountSmileys(string[] smileys)
    {
        return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
    }

    //Console.WriteLine(CountSmileys(new string[] { ":)", ";(", ";}", ":-D" }));
    //Console.WriteLine(CountSmileys(new string[] { ";D", ":-(", ":-)", ";~)" }));
    //Console.WriteLine(CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
}
