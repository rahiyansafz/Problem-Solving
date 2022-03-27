namespace Competitive_Programming.Problems;

internal class CountingDuplicateNumbers
{
    //## Count the number of Duplicates =>
    public static int Duplicatecount(string str)
    {
        return str.ToLower().GroupBy(x => x).Select(y => y).Where(z => z.Count() > 1).Count();
    }

}