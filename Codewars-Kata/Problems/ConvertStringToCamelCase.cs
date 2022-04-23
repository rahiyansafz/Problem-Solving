using System.Text.RegularExpressions;

namespace Codewars_Kata.Problems;

internal class ConvertStringToCamelCase
{
    //## Convert string to camelCase =>
    //Complete the method/function so that it converts dash/underscore delimited words into camel casing.The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
    //Examples

    //"the-stealth-warrior" gets converted to "theStealthWarrior"
    //"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

    public static string ToCamelCase(string str)
    {
        return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        //return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
    }
}
