// See https://aka.ms/new-console-template for more information
Console.WriteLine("Codewars Kata");

Console.WriteLine("\n");
Console.WriteLine("\n");

//Codewars Kata

//## Count the number of Duplicates =>

//Solution => 

static int duplicatecount(string str)
{
    return str.ToLower().GroupBy(x => x).Select(y => y).Where(z => z.Count() > 1).Count();
}
Console.WriteLine("Kata Count the number of Duplicates: \n");
Console.WriteLine(duplicatecount("AAABBcasd"));
Console.WriteLine("\n");


//Sample Tests => 
//using System;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Linq;
//using NUnit.Framework;

//[TestFixture]
//public class KataTest
//{
//    [Test]
//    public void KataTests()
//    {
//        Assert.AreEqual(0, Kata.DuplicateCount(""));
//        Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
//        Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
//        Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
//        Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
//        Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
//    }
//}

//## A square of squares =>

//Solution => 

static bool IsSquare(int n)
{
    //Your code goes here!
    //var numCheck = (Math.Sqrt(n) % 1) == 0;
    return ((Math.Sqrt(n) % 1) == 0);
}

Console.WriteLine("Kata A square of squares: \n");
Console.WriteLine(IsSquare(7));
Console.WriteLine(IsSquare(4));
Console.WriteLine(IsSquare(0));
Console.WriteLine(IsSquare(2));
Console.WriteLine("\n");

//## Your order, please =>

//Solution =>

static string Order(string words)
{
    if (string.IsNullOrEmpty(words)) return words;
    return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
}

Console.WriteLine("Kata Your order, please: \n");
Console.WriteLine(Order("is2 Thi1s T4est 3a"));
Console.WriteLine(Order("4of Fo1r pe6ople g3ood th5e the2"));
Console.WriteLine(Order(""));
Console.WriteLine("\n");