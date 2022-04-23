using System.Text.RegularExpressions;

namespace Codewars_Kata.Problems;

internal class SplitStrings
{
    //Complete the solution so that it splits the string into pairs of two characters.If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

    //Examples:
    //* 'abc' =>  ['ab', 'c_']
    //* 'abcdef' => ['ab', 'cd', 'ef']

    //public static string[] Solution(string str) => Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();

    public static string[] Solution(string str)
    {
        if (str.Length % 2 == 1)
            str += "_";

        List<string> list = new();
        for (int i = 0; i < str.Length; i += 2)
        {
            list.Add(str[i].ToString() + str[i + 1]);
        }

        return list.ToArray();
    }

}
