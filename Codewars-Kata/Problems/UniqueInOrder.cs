namespace Codewars_Kata.Problems;

internal class UniqueInOrder
{
    //## Unique In Order
    //Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

    //For example:

    //uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
    //uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
    //uniqueInOrder([1,2,2,3,3])       == {1,2,3}

    public static IEnumerable<T> Solution<T>(IEnumerable<T> iterable)
    {
        //var arr = iterable.ToList();
        //return arr.Where((x, i) => i == 0 || !Equals(x, arr.ElementAt(i - 1)));

        T? previous = default;
        foreach (T current in iterable)
        {
            if (!current!.Equals(previous))
            {
                previous = current;
                yield return current;
            }
        }
    }

    //Console.WriteLine(UniqueInOrder("AAAABBBCCDAABBB"));
    //Console.WriteLine(UniqueInOrder("ABBCcAD"));
    //Console.WriteLine(UniqueInOrder(new List<int> { 1, 2, 3 }));
}
