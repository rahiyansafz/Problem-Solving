namespace Codewars_Kata.Problems;

//All Balanced Parentheses
//Write a function which makes a list of strings representing all of the ways you can balance n pairs of parentheses
//Examples

//BalancedParens(0) returns List<string> with element:  ""
//BalancedParens(1) returns List<string> with element:  "()"
//BalancedParens(2) returns List<string> with elements: "()()","(())"
//BalancedParens(3) returns List<string> with elements: "()()()","(())()","()(())","(()())","((()))"

internal class Balanced
{
    public static void RecursiveParens(string s, int n, int nOpen, int nClosed, List<string> res)
    {
        if (nOpen < n)
            RecursiveParens(s + "(", n, nOpen + 1, nClosed, res);
        if (nClosed < nOpen)
            RecursiveParens(s + ")", n, nOpen, nClosed + 1, res);
        if (nOpen == n && nClosed == n)
            res.Add(s);
    }

    public static List<string> BalancedParens(int n)
    {
        var res = new List<string>();
        RecursiveParens("", n, 0, 0, res);
        return res;
    }
}
