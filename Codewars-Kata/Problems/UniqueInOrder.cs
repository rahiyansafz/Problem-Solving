using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Kata.Problems
{
    internal class UniqueInOrder
    {
        //## Unique In Order
        static IEnumerable<T> UniqueInOrderCP<T>(IEnumerable<T> iterable)
        {
            var arr = iterable.ToList();
            return arr.Where((x, i) => i == 0 || !Equals(x, arr.ElementAt(i - 1)));
            //T? previous = default;
            //foreach (T current in iterable)
            //{
            //    if (!current.Equals(previous))
            //    {
            //        previous = current;
            //        yield return current;
            //    }
            //}
        }

        //Console.WriteLine(UniqueInOrder("AAAABBBCCDAABBB"));
        //Console.WriteLine(UniqueInOrder("ABBCcAD"));
        //Console.WriteLine(UniqueInOrder(new List<int> { 1, 2, 3 }));
    }
}
