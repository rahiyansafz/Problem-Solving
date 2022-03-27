using System.Text.RegularExpressions;

namespace Codewars_Kata.Problems;

internal class ConvertStringToCamelCase
{
    //## Convert string to camelCase =>
    public static string ToCamelCase(string str)
    {
        return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        //return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
    }
}
