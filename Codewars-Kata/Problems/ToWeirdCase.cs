using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Codewars_Kata.Problems;

internal class ToWeirdCase
{
    //WeIrD StRiNg CaSe
    //Write a function toWeirdCase(weirdcase in Ruby) that accepts a string, and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters in each word lower cased.The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased and you need to start over for each word.

    //The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words.Words will be separated by a single space(' ').

    //Examples:
    //toWeirdCase( "String" );//=> returns "StRiNg"
    //toWeirdCase( "Weird string case" );//=> returns "WeIrD StRiNg CaSe"

    public static string Solution(string s)
    {
        return string.Join(" ",
      s.Split(' ')
      .Select(w => string.Concat(
        w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
      ))));
    }

    //public static string ToWeirdCase(string s)
    //{
    //    char[] r = new char[s.Length];

    //    for (int i = 0, x = 0; i < s.Length; i++, x++)
    //    {
    //        x = (s[i] == ' ') ? -1 : x;
    //        r[i] = ((x % 2) == 0) ? Char.ToUpper(s[i]) : Char.ToLower(s[i]);
    //    }

    //    return new string(r);
    //}
}
