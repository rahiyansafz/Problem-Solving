using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Kata.Problems
{
    internal class ASquareOfSquares
    {
        //## A square of squares =>
        private static bool IsSquare(int n)
        {
            //var numCheck = (Math.Sqrt(n) % 1) == 0;
            return ((Math.Sqrt(n) % 1) == 0);
        }
    }
}
