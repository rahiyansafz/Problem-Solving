namespace Codewars_Kata.Problems;

internal class Encryption
{
    // ##Encryption 
    public static void EncryptionCP()
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
}


////////////////////////////////////////////////////////////////////////////////////////
///

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

                        //static void Encryption()
                        //{
                        //    var InputText = Console.ReadLine();
                        //    if (InputText is not null)
                        //    {
                        //        var colCount = (int)Math.Ceiling(Math.Sqrt(InputText.Length));

                        //        for (int i = 0; i < colCount; i++)
                        //        {
                        //            var counter = 0;
                        //            while (i + (counter * colCount) < InputText.Length)
                        //            {
                        //                Console.Write(InputText[i + (counter * colCount)]);
                        //                counter++;
                        //            }
                        //            Console.Write(' ');
                        //        }
                        //    }
                        //}

                        //Console.WriteLine("Encryption: \n");
                        //Encryption();
                        //Console.WriteLine("\n");

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
