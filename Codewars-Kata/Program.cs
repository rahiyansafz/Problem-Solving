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