﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Kata.Problems
{
    internal class SumOfNumbers
    {
        //## Sum of Numbers =>
        static int GetSum(int a, int b)
        {
            //var result = 0;
            //for (var i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            //{
            //    result += i;
            //}
            //return result;
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }
    }
}
