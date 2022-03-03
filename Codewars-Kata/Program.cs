// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

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

//## Beginner Series #3 Sum of Numbers =>

//Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
//Note: a and b are not ordered!
//Examples(a, b)-- > output(explanation)
//(1, 0)-- > 1(1 + 0 = 1)
//(1, 2)-- > 3(1 + 2 = 3)
//(0, 1)-- > 1(0 + 1 = 1)
//(1, 1)-- > 1(1 since both are same)
//(-1, 0)-- > -1(-1 + 0 = -1)
//(-1, 2)-- > 2(-1 + 0 + 1 + 2 = 2)

//Solution =>

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

Console.WriteLine("Kata Beginner Series #3 Sum of Numbers: \n");
Console.WriteLine(GetSum(-1, 0));
Console.WriteLine(GetSum(-1, 2));
Console.WriteLine(GetSum(1, 1));
Console.WriteLine(GetSum(1, 0));
Console.WriteLine("\n");

//## Is this a triangle? =>

//Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with the sides of given length and false in any other case.
//(In this case, all triangles must have surface greater than 0 to be accepted).

//Solution => 

static bool IsTriangle(int a, int b, int c) => a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
//{
//    return a + b > c && b + c > a && a + c > b;
//}

Console.WriteLine("Kata Is this a triangle?: \n");
Console.WriteLine(IsTriangle(3, 3, 4));
Console.WriteLine(IsTriangle(4, 4, 4));
Console.WriteLine(IsTriangle(4, 4, 3));
Console.WriteLine(IsTriangle(0, 0, 0));
Console.WriteLine("\n");


//## Convert string to camel case =>

//Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

//Examples
//"the-stealth-warrior" gets converted to "theStealthWarrior"
//"The_Stealth_Warrior" gets converted to "TheStealthWarrior"

//Solution => 

static string ToCamelCase(string str)
{
    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
    //return string.Concat(str.Split('-', '_').Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
}

Console.WriteLine("Convert string to camel case: \n");
Console.WriteLine(ToCamelCase("the-stealth-warrior"));
Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
Console.WriteLine("\n");

//## Unique In Order

//Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

//For example:
//uniqueInOrder("AAAABBBCCDAABBB") == { 'A', 'B', 'C', 'D', 'A', 'B'}
//uniqueInOrder("ABBCcAD") == { 'A', 'B', 'C', 'c', 'A', 'D'}
//uniqueInOrder([1, 2, 2, 3, 3]) == { 1,2,3}

//Solution => 

static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
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

Console.WriteLine("Unique In Order: \n");
Console.WriteLine(UniqueInOrder("AAAABBBCCDAABBB"));
Console.WriteLine(UniqueInOrder("ABBCcAD"));
Console.WriteLine(UniqueInOrder(new List<int> { 1, 2, 3 }));
Console.WriteLine("\n");


//## Persistent Bugger.

//Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

//For example(Input --> Output):
//39-- > 3(because 3 * 9 = 27, 2 * 7 = 14, 1 * 4 = 4 and 4 has only one digit)
//999-- > 4(because 9 * 9 * 9 = 729, 7 * 2 * 9 = 126, 1 * 2 * 6 = 12, and finally 1 * 2 = 2)
//4-- > 0(because 4 is already a one - digit number)

//Solution => 

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

Console.WriteLine("Persistent Bugger.: \n");
Console.WriteLine(Persistence(39));
Console.WriteLine(Persistence(999));
Console.WriteLine(Persistence(4));
Console.WriteLine("\n");

//## Count the smiley faces!


//Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

//Rules for a smiling face:

//    Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or;
//A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
//    Every smiling face must have a smiling mouth that should be marked with either ) or D

//No additional characters are allowed except for those mentioned.

//Valid smiley face examples: :) :D; -D :~)
//Invalid smiley faces: ; ( :> :} :]


//Example
//countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
//countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
//countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;

//Note

//In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). Order of the face (eyes, nose, mouth) elements will always be the same.

static int CountSmileys(string[] smileys)
{
    return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
}

Console.WriteLine("Count the smiley faces!: \n");
Console.WriteLine(CountSmileys(new string[] { ":)", ";(", ";}", ":-D" }));
Console.WriteLine(CountSmileys(new string[] { ";D", ":-(", ":-)", ";~)" }));
Console.WriteLine(CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
Console.WriteLine("\n");



// ##Encryption 

/*
 Problem: https://www.hackerrank.com/challenges/encryption/problem
 C# Language Version: 10.0
 .Net Framework Version: 6.0
 Tool Version : Visual Studio Community 2022
 Thoughts :
 1. Let the input string be s.
 2. Let the input string s be of length l.
 3. Get the number of column count when we arrange s as a grid using forumula Ceiling(sqrt(l)). let it be cc.
 4. Start a loop which runs with a counter i starting from 0 to cc-1.
    4.1 Initialize a counter c to 0.
    4.2 start a while loop until i + (c * cc) < l
         4.2.1 print the (i + (c * cc))th character of s on console.
         4.2.2 increment c by 1
    4.3 print a space character on console.
    4.4 repeat steps 4.1 to 4.3 untill loop condition is true.
 Time Complexity:  O(n)
 Space Complexity: O(1) //Number of dynamically allocated variables remain constant for any length of string input.
*/

static void Encryption()
{
    var InputText = Console.ReadLine();
    if (InputText is not null)
    {
        var colCount = (int)Math.Ceiling(Math.Sqrt(InputText.Length));

        for (int i = 0; i < colCount; i++)
        {
            var counter = 0;
            while (i + (counter * colCount) < InputText.Length)
            {
                Console.Write(InputText[i + (counter * colCount)]);
                counter++;
            }
            Console.Write(' ');
        }
    }
}

Console.WriteLine("Encryption: \n");
Encryption();
Console.WriteLine("\n");

//Hackerrank boilerplate solution =>

//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Result
//{

//    /*
//     * Complete the 'encryption' function below.
//     *
//     * The function is expected to return a STRING.
//     * The function accepts STRING s as parameter.
//     */

//    public static string encryption(string s)
//    {
//        var rows = (int)Math.Ceiling(Math.Sqrt(s.Length));

//        var lines = new string[rows];
//        for (int i = 0; i < s.Length; i++)
//            lines[i % rows] += s[i];

//        return string.Join(" ", lines);
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string s = Console.ReadLine();

//        string result = Result.encryption(s);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
