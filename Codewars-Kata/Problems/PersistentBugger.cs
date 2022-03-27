using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Kata.Problems
{
    internal class PersistentBugger
    {
        //## Persistent Bugger.
        static int Persistence(long n)
        {
            //return n < 10 ? 0 : 1 + Persistence($"{n}".Aggregate(1, (a, b) => a * (b - 48)));
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }
    }
}
