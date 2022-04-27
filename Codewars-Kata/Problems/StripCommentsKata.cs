namespace Codewars_Kata.Problems;

internal class StripCommentsKata
{
    //    Strip Comments
    //      Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

    //      Example:

    //      Given an input string of:

    //      apples, pears # and bananas
    //      grapes
    //      bananas !apples

    //      The output expected would be:

    //      apples, pears
    //      grapes
    //      bananas

    //      The code would be called like so:

    //      string stripped = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" })
    //      // result should == "apples, pears\ngrapes\nbananas"

    public static string StripComments(string text, string[] commentSymbols)
    {
        var lines = text.Split("\n");

        foreach (var symbol in commentSymbols)
            for (var i = 0; i < lines.Length; i++)
            {
                var pos = lines[i].IndexOf(symbol);
                if (pos > -1) lines[i] = lines[i].Remove(pos);
                lines[i] = lines[i].TrimEnd();
            }

        return string.Join("\n", lines);
    }
}


//Approach 2 
//    public static string StripComments(string text, string[] commentSymbols)
//{
//    string[] lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
//    lines = lines.Select(x => x.Split(commentSymbols, StringSplitOptions.None).First().TrimEnd()).ToArray();
//    return string.Join("\n", lines);
//}

//Approach 3
//    public static string StripComments(string text, string[] commentSymbols)
//{
//    return string
//      .Join("\n", text.Split("\n")
//      .Select(x => x.Split(commentSymbols, StringSplitOptions.None)[0]
//      .TrimEnd(' ')));
//}

//Approach 4
//        public static string StripComments(string text, string[] commentSymbols)
//{
//    return String.Join('\n', text.Split('\n').Select(str => str.Split(commentSymbols, 0)[0].TrimEnd()));
//}