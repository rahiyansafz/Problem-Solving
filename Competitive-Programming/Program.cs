// See https://aka.ms/new-console-template for more information
using Competitive_Programming.Problems;

AddTwoNumbers.AddAndMultiply(1.7, 9.9, 0.01);

ElementaryOperations.EOperations(-375, 25);

IsResultSame.IsResultTheSame(3 + 7, 12 - 2);

ModuloOperations.ModOperations(1, 1, 1);

TheCubeOf.Cube(3);

SwapTwoNumbers.Swap(-123, 999);

AbsoluteValue.Absolute(-999);

DivisibleBy.IsDivisible(444, 0);

ConsistencyOfUpperCase.IfConsistsOfUppercaseLetters("drY");

GreaterThanThirdOne.IfGreaterThanThirdOne(new int[] { -15, -25, 100 });

IfNumberIsEven.IsNumberEven(-43234670);

IfSortedArray.IsSortedByAscending(new int[] { 3, 6, 9 });

IfHasANeighbour.HasNeighbour("PRT"); // "DCA"

PositiveNegativeOrZero.StateOfNumber(0.0);

LeapYear.IsYearLeap(2023);

ContainingThree.IsContainThree(5384562);

MultiplicationTable.MultiplicatedTable();

FractionsSum.FractedSum(7);

int[] sortedArr = SortArrayAscending.AscendingSortedArray(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });

foreach (var s in sortedArr)
{
    Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
}
Console.WriteLine("\n");


BiggestNumber.TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 });

TwoSevensNextToEachOther.IsNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 });

ThreeIncreasingAdjacent.IsAdjacentToThree(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 });

ReturnEvenNumbers.EvenNumbers();

//Sieve of Eratosthenes

//Given an integer n (n>2), write a method that returns prime numbers from range [2, n].
//Expected input and output
//SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29] 

static bool[] SieveOfEratosthenes(int n)
{
    bool[] array = new bool[n];

    for (int i = 2; i < n; i++)
    {
        array[i] = true;
    }

    for (int j = 2; j * j <= n; j++)
    {
        if (array[j] == true)
        {
            for (int k = j * j; k < n; k += j)
            {
                array[k] = false;
            }
        }
    }
    return array;
}

var arrayOfPrimes = SieveOfEratosthenes(100);
Console.WriteLine("Sieve of EratosthenesL: \n");

for (int i = 0; i < arrayOfPrimes.Length; i++)
{
    if (arrayOfPrimes[i] != false)
    {
        Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 
    }
}
Console.WriteLine("\n");

//Draw Hourglass

//Write a method that draws hourglass shape like below.
//Expected input and output
//DrawHourglass() →

//***********
// *********
//  *******
//   *****
//    ***
//     *
//    ***
//   *****
//  *******
// *********
//***********

static void DrawHourglass()
{
    for (var i = 0; i <= 10; i++)
    {
        for (var j = 0; j < (i <= 5 ? i : 10 - i); j++)
        {
            Console.Write(" ");
        }
        for (var k = i <= 5 ? i : 10 - i; k <= (i <= 5 ? 10 - i : i); k++)
        {
            Console.Write("*");
        }
        for (var m = 10 - i; m < 10; m++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Draw Hourglass: \n");
DrawHourglass();
Console.WriteLine("\n");

//Draw Parallelogram

//Write a method that draws parallelogram shape like below.
//Expected input and output
//DrawParallelogram() →
//     ***************
//    ***************
//   ***************
//  ***************
// ***************

static void DrawParallelogram()
{
    for (var j = 0; j < 5; j++)
    {
        for (var k = 0; k < 5 - j; k++)
        {
            Console.Write(" ");
        }
        for (var m = 0; m < 15; m++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Draw Parallelogram: \n");
DrawParallelogram();
Console.WriteLine("\n");

//Draw Christmas Tree

//Write a method that draws Christmas tree shape like below.
//Expected input and output
//DrawChristmasTree() →
//   *
//  ***
// *****
//*******
//   *
//  ***
// *****
//*******
//   *
//  ***
// *****
//*******

static void DrawChristmasTree()
{
    for (var i = 0; i < 3; i++)
    {
        for (var j = 0; j < 7; j += 2)
        {
            for (var k = 0; k < (7 - j) / 2; k++)
            {
                Console.Write(" ");
            }
            for (var m = 0; m <= j; m++)
            {
                Console.Write("*");
            }
            for (var n = (7 - j) / 2; n < 7; n++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Draw Christmas Tree: \n");
DrawChristmasTree();
Console.WriteLine("\n");

//Extract String

//Given a string, write a method that returns substring from between two double hash signs (#).
//Expected input and output
//ExtractString("##abc##def") → "abc"
//ExtractString("12####78") → empty string
//ExtractString("gar##d#en") → empty string
//ExtractString("++##--##++") → "--"

static string ExtractString(string word)
{
    string extractedWord = string.Empty;

    for (int i = 0; i <= word.Length - 1; i++)
    {
        if (word[i] == '#' && word[i + 1] == '#')
        {
            for (int j = i + 2; j <= word.Length - 1; j++)
            {
                if (word[j] == '#' && word[j + 1] == '#')
                {
                    return extractedWord;
                }
                extractedWord += word[j];
            }
        }
    }

    return string.Empty;
}

Console.WriteLine("Extract String: \n");
Console.WriteLine(ExtractString("kFp##jFoRj##pL")); // jFoRj
Console.WriteLine(ExtractString("abc##def"));       // /empty string/
Console.WriteLine(ExtractString("##123456789##"));  // 123456789
Console.WriteLine(ExtractString("no####thing"));    // /empty string/
Console.WriteLine(ExtractString("empty"));          // /empty string/
Console.WriteLine("\n");

//Full Sequence Of Letters

//Given a string of two letters, where first one occurs before the second in the alphabet, write a method that returns full sequence of letters starting from first and ending at the second one.
//Expected input and output
//FullSequenceOfLetters("ds") → "defghijklmnopqrs"
//FullSequenceOfLetters("or") → "opqr"

static string FullSequenceOfLetters(string word)
{
    string fullSequence = string.Empty;
    for (int i = word[0], j = 0; i <= word[1]; i++, j++)
    {
        fullSequence += (char)(word[0] + j);
    }

    return fullSequence;
}

Console.WriteLine("Full Sequence Of Letters: \n");
Console.WriteLine(FullSequenceOfLetters("bg")); // bcdefg
Console.WriteLine(FullSequenceOfLetters("xy")); // xy            
Console.WriteLine(FullSequenceOfLetters("az")); // abcdefghijklmnopqrstuvwxyz
Console.WriteLine("\n");


//Longest Strictly Increasing Sequence

//Given an array of integers, write a method that returns value of the longest strictly increasing sequence of numbers.
//Expected input and output
//LongestStrictlyIncreasingSequence([0, 3, 4, 5, 6, 4, 9]) → 3
//LongestStrictlyIncreasingSequence([7, 7, 7, 7, 7]) → 0

static int LongestStrictlyIncreasingSequence(int[] array)
{
    int tempLongest = 0;
    int longest = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] > array[i])
        {
            tempLongest++;
        }
        else
        {
            tempLongest = 0;
        }

        if (tempLongest > longest)
        {
            longest = tempLongest;
        }
    }

    return longest;
}


Console.WriteLine("Longest Strictly Increasing Sequence: \n");
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 })); // 4
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 })); // 1
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 })); // 6
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 1, 1, 1, 1, })); // 0
Console.WriteLine("\n");

//Bits To Number

//Write a method that takes non-empty string of bits as an argument and returns number as integer.
//Expected input and output
//BitsToNumber("1") → 1
//BitsToNumber("100010") → 34

static int BitsToNumber(string bits)
{
    var number = 0;

    for (var i = 0; i < bits.Length; i++)
    {
        number += (int)(char.GetNumericValue(bits[i]) * Math.Pow(2, bits.Length - i - 1));
    }
    return number;
}

Console.WriteLine("Bits To Number: \n");
Console.WriteLine(BitsToNumber("0"));                   // 0
Console.WriteLine(BitsToNumber("00001011000001"));      // 705
Console.WriteLine(BitsToNumber("10001110001010100"));   // 72288
Console.WriteLine("\n");

//Digits Sum

//Given a non-negative number, write a method that returns sum of its digits.
//Expected input and output
//DigitsSum(5434) → 16
//DigitsSum(904861) → 28

static int DigitsSum(uint number)
{
    int sum = 0;
    int i = 10;
    int j = 1;

    while (number / j >= 1)
    {
        sum += (int)(number % i / j);

        i *= 10;
        j *= 10;
    }

    return sum;
}

Console.WriteLine("Digits Sum: \n");
Console.WriteLine(DigitsSum(5));  // 5
Console.WriteLine(DigitsSum(1029584739)); // 48
Console.WriteLine(DigitsSum(99999999));    // 72
Console.WriteLine("\n");

//Sum And Average

//Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m].
//Expected input and output
//SumAndAverage(11, 66) → "Sum: 2156, Average: 38.5"
//SumAndAverage(-10, 0) → "Sum: -55, Average: -5"

static string SumAndAverage(int lowest, int highest)
{
    int sum = 0;
    int range = 0;
    for (int i = lowest; i <= highest; i++)
    {
        sum += i;
        range++;
    }

    double average = sum / (double)range;

    return string.Format($"Sum: {sum}, Average: {average}");
}

Console.WriteLine("Sum And Average: \n");
Console.WriteLine(SumAndAverage(20, 21)); // Sum: 41 Average: 20,5
Console.WriteLine(SumAndAverage(55, 55)); // Sum: 55 Average: 55
Console.WriteLine(SumAndAverage(0, 100)); // Sum: 5050 Average: 50
Console.WriteLine("\n");

//Sum Double Only

//Given an array of objects, write a method that returns sum of objects of double type.
//Expected input and output
//SumDoubleOnly(["abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22]) → 7.82

static double SumDoubleOnly(object[] obj)
{
    double sum = 0.0;
    for (int i = 0; i < obj.Length; i++)
    {
        //if (obj[i] is double)
        //{
        //    sum += (double)obj[i];
        //}
        if (obj[i] is double @double)
        {
            sum += @double;
        }
    }

    return sum;
}

Console.WriteLine("Sum Double Only: \n");
Console.WriteLine(SumDoubleOnly(new object[] { 8.9, "dog", 6, 'c', 15.99, 745, true })); // 24.89
Console.WriteLine("\n");

//Draw Triangle

//Write a method that draws triangle shape like below.
//Expected input and output
// DrawTriangle() →
//         *
//        **
//       ***
//      ****
//     *****
//    ******
//   *******
//  ********
// *********
//**********

static void DrawTriangle()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 10; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int k = 10; k >= 10 - i; k--)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Draw Triangle: \n");
DrawTriangle();
Console.WriteLine("\n");

//To The Power Of

//Given two integers, write a method that returns first number raised to the power of second one.
//Expected input and output
//ToThePowerOf(-2, 3) → -8
//ToThePowerOf(5, 5) → 3125

static double ToThePowerOf(int b, int exp)
{
    double result = 1;
    if (exp == 0)
    {
        return 1;
    }

    for (int i = 1; exp > 0 ? i <= exp : i <= exp * (-1); i++)
    {
        result *= b;
    }

    return exp > 0 ? result : 1 / result;
}

Console.WriteLine("To The Power Of: \n");
Console.WriteLine(ToThePowerOf(10, 0)); // 1
Console.WriteLine(ToThePowerOf(5, -2)); // 0.04
Console.WriteLine(ToThePowerOf(8, -8)); // 5.96046447753906E-08
Console.WriteLine(ToThePowerOf(0, 5));  // 0
Console.WriteLine("\n");

//Letters Balance

//Given a string, write a method that checks if there are exactly the same letters on the left side and right side of the string. Assume string length is even and letters don't repeat on each side.
//Expected input and output
//LettersBalance("fgvgvf") → true
//LettersBalance("lampsmpser") → false

static bool LettersBalance(string word)
{
    bool isBalanced;
    for (int i = 0; i < word.Length / 2; i++)
    {
        isBalanced = false;
        for (int j = word.Length - 1; j >= word.Length / 2; j--)
        {
            if (word[i] == word[j])
            {
                isBalanced = true;
            }
        }

        if (!isBalanced)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("Letters Balance: \n");
Console.WriteLine(LettersBalance("kfdfdk"));           // True
Console.WriteLine(LettersBalance("reyjer"));           // False
Console.WriteLine(LettersBalance("wkxzcsazsckawx"));   // True
Console.WriteLine(LettersBalance("pkmqsdedeskgqm"));   // False
Console.WriteLine("\n");

//Replace Two Words

//Given a string in which two words are separated by a char, write a method that replaces these two words.
//Expected input and output
//ReplaceWords("abc_xyz", '_') → xyz_abc
//ReplaceWords("trolling.master", '.') → master.trolling

static string ReplaceWords(string word, char ch)
{
    string firstWord = string.Empty;
    string secondWord = string.Empty;

    for (int i = 0; i <= word.Length - 1; i++)
    {
        if (word[i] != ch)
        {
            secondWord += word[i];
        }
        else
        {
            for (int j = i + 1; j <= word.Length - 1; j++)
            {
                firstWord += word[j];
            }
            break;
        }
    }

    return firstWord + ch + secondWord;
}


Console.WriteLine("Replace Two Words: \n");
Console.WriteLine(ReplaceWords("dog_octopus", '_'));     // octopus_dog
Console.WriteLine(ReplaceWords("a.b", '.'));                     // b.a
Console.WriteLine(ReplaceWords("good very", ' '));         // very good
Console.WriteLine("\n");

//Digital Root

//Given a non-negative number, write a method that returns its digital root. From Wikipedia - digital root is a value obtained by an iterative process of summing digits, on each iteration using the result from the previous iteration to compute a digit sum. The process continues until a single-digit number is reached.
//Expected input and output
//DigitalRoot(83) → 2
//DigitalRoot(40002938) → 8

static int DigitalRoot(uint number)
{
    while (number / 10 != 0)
    {
        uint sum = 0;
        int i = 10;
        int j = 1;

        while (number / j >= 1)
        {
            sum += (uint)(number % i / j);

            i *= 10;
            j *= 10;
        }

        number = sum;
    }

    return (int)number;
}

Console.WriteLine("Digital Root: \n");
Console.WriteLine(DigitalRoot(5));          // 5
Console.WriteLine(DigitalRoot(1029584739)); // 3
Console.WriteLine(DigitalRoot(99999999));   // 9
Console.WriteLine("\n");

//Check Brackets Sequence

//Given a sequence of brackets, write a method that checks if it has the same number of opening and closing brackets.
//Expected input and output
//CheckBracketsSequence("((()))") → true
//CheckBracketsSequence("()(())(") → false
//CheckBracketsSequence(")") → false

static bool CheckBracketsSequence(string sequence)
{
    int check = 0;

    for (int i = 0; i < sequence.Length; i++)
    {
        check = sequence[i] == '(' ? ++check : --check;
    }

    return check == 0;
}

Console.WriteLine("Check Brackets Sequence: \n");
Console.WriteLine(CheckBracketsSequence("((()()()))"));           // True
Console.WriteLine(CheckBracketsSequence(")"));                    // False
Console.WriteLine(CheckBracketsSequence(")(())("));               // True
Console.WriteLine(CheckBracketsSequence("()())()"));              // False
Console.WriteLine(CheckBracketsSequence("((()(((()())))())())")); // True
Console.WriteLine("\n");

//Add Separator

//Given a string and a separator, write a method that adds separator between each adjacent characters in a string.
//Expected input and output
//AddSeparator("ABCD", "^") → "A^B^C^D^"
//AddSeparator("chocolate", "-") → "c-h-o-c-o-l-a-t-e"

static string AddSeparator(string word, string separator)
{
    string separatedWord = string.Empty;

    for (int i = 0; i < word.Length; i++)
    {
        separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();
    }

    return separatedWord;
}

Console.WriteLine("Add Separator: \n");
Console.WriteLine(AddSeparator("computer", "_"));  // c_o_m_p_u_t_e_r
Console.WriteLine(AddSeparator("$*(#", " "));       // $ * ( #
Console.WriteLine(AddSeparator("AC", "B"));        // ABC
Console.WriteLine(AddSeparator("octopus", "X"));   // oXcXtXoXpXuXs
Console.WriteLine("\n");

//Is Palindrome

//Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.
//Expected input and output
//IsPalindrome("eye") → true
//IsPalindrome("home") → false

static bool IsPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("Is Palindrome: \n");
Console.WriteLine(IsPalindrome("madam"));  // True
Console.WriteLine(IsPalindrome("123454321"));  // True
Console.WriteLine(IsPalindrome("apple"));  // False
Console.WriteLine(IsPalindrome("Never Odd Or Even"));  // True
Console.WriteLine(IsPalindrome("Curabitur vel est diam"));  // False
Console.WriteLine(IsPalindrome("x"));  // True
Console.WriteLine("\n");

//Length Of String

//Given a string, write a method that returns its length. Do not use library methods!
//Expected input and output
//LengthOfAString("computer") → 8
//LengthOfAString("ice cream") → 9

static int LengthOfAString(string str)
{
    int length = 0;
    foreach (char c in str)
    {
        length++;
    }

    return length;
}

Console.WriteLine("Length Of String: \n");
Console.WriteLine(LengthOfAString("Lorem ipsum dolor sit amet")); //26
Console.WriteLine(LengthOfAString(string.Empty));                 //0
Console.WriteLine(LengthOfAString("conse12ctetur "));             //14
Console.WriteLine("\n");

//String In Reverse Order

//Given a string, write a method that returns that string in reverse order.
//Expected input and output
//StringInReverseOrder("qwerty") → "ytrewq"
//StringInReverseOrder("oe93 kr") → "rk 39eo"

static string StringInReverseOrder(string str)
{
    string reverseString = string.Empty;
    for (int i = str.Length - 1; i >= 0; i--)
    {
        reverseString += str[i];
    }

    return reverseString;
}

Console.WriteLine("String In Reverse Order: \n");
Console.WriteLine(StringInReverseOrder("Vivamus commodo quam at purus "));  //  surup ta mauq odommoc sumaviV
Console.WriteLine(StringInReverseOrder("34 ( 9  9@*"));  // *@9  9 ( 43
Console.WriteLine(StringInReverseOrder("malesuada"));  // adauselam
Console.WriteLine("\n");

//Sum Digits In String

//Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.
//Expected input and output
//SumDigitsInString("1q2w3e") → 6
//SumDigitsInString("L0r3m.1p5um") → 9
//SumDigitsInString("") → 0

static int SumDigitsInString(string str)
{
    var sum = 0;

    for (var i = 0; i < str.Length; i++)
    {
        if (char.IsDigit(str[i]))
        {
            sum += (int)char.GetNumericValue(str[i]);
        }
    }

    return sum;
}

Console.WriteLine("Sum Digits In String: \n");
Console.WriteLine(SumDigitsInString("aaa5aa5aa5a5a")); // 20
Console.WriteLine(SumDigitsInString("10r3m1p5um")); // 10
Console.WriteLine(SumDigitsInString("tt")); //0
Console.WriteLine("\n");

//Make Uppercase

//Given a string, write a method that returns new string in which every odd letter of the word is uppercase. String may consist of one or more words.
//Expected input and output
//MakeUppercase("modem") → "MoDeM"
//MakeUppercase("BookWorm") → "BoOkWoRm"
//MakeUppercase("Aliquam dolor nisl?") → "AlIqUaM DoLoR NiSl?"

static string MakeUppercase(string word)
{
    int letterIndex = 0;
    string uppercaseWord = string.Empty;

    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] >= 'a' && word[i] <= 'z' && letterIndex % 2 == 0)
        {
            letterIndex++;
            uppercaseWord += (char)(word[i] - 32);
        }
        else if (word[i] != ' ')
        {
            letterIndex++;
            uppercaseWord += word[i];
        }
        else
        {
            letterIndex = 0;
            uppercaseWord += word[i];
        }
    }
    return uppercaseWord;
}

Console.WriteLine("Make Uppercase: \n");
Console.WriteLine(MakeUppercase("very short sentence."));   // VeRy ShOrT SeNtEnCe.
Console.WriteLine(MakeUppercase("motorcycle"));             // MoToRcYcLe
Console.WriteLine(MakeUppercase("Events And Delegates"));   // EvEnTs AnD DeLeGaTeS
Console.WriteLine("\n");

//Mix Two Strings

//Given two strings, write a method that returns one string made of two strings. First letter of new string is first letter of first string, second letter of new string is first letter of second string and so on.
//Expected input and output
//MixTwoStrings("aaa", "BBB") → "aBaBaB"
//MixTwoStrings("good one", "111") → "g1o1o1d one"

static string MixTwoStrings(string word1, string word2)
{
    string mixedWord = string.Empty;

    for (int i = 0; i < (word1.Length > word2.Length ? word1.Length : word2.Length); i++)
    {
        if (i < word1.Length)
        {
            mixedWord += word1[i];
        }
        if (i < word2.Length)
        {
            mixedWord += word2[i];
        }
    }

    return mixedWord;
}

Console.WriteLine("Mix Two Strings: \n");
Console.WriteLine(MixTwoStrings("DoG", "ElEpHaNt"));           // DEolGEpHaNt
Console.WriteLine(MixTwoStrings("The tallest", "XXXXXXXXXX")); // TXhXeX XtXaXlXlXeXsXt
Console.WriteLine("\n");

//Number Of Words

//Given a string, write a method that counts its number of words. Assume there are no leading and trailing whitespaces and there is only single whitespace between two consecutive words.
//Expected input and output
//NumberOfWords("This is sample sentence") → 4
//NumberOfWords("OK") → 1

static int NumberOfWords(string str)
{
    int numberOfWords = 0;
    for (int i = 1; i < str.Length; i++)
    {
        numberOfWords = (char.IsWhiteSpace(str[i]) ? numberOfWords + 1 : numberOfWords);
    }

    return numberOfWords + 1;
}

Console.WriteLine("Number Of Words: \n");
Console.WriteLine(NumberOfWords("Mauris consectetur urna sit amet risus ultricies rutrum."));  // 8
Console.WriteLine(NumberOfWords("Quisque M"));  // 2
Console.WriteLine(NumberOfWords("Xor"));  // 1
Console.WriteLine("\n");

//Revert Words Order

//Given a string, write a method that returns new string with reverted words order. Pay attention to the punctuation at the end of the sentence (period).
//Expected input and output
//RevertWordsOrder("John Doe.") → "Doe John."
//RevertWordsOrder("A, B. C") → "C B. A,"

static string RevertWordsOrder(string str)
{
    string[] strArray = str.Split(' ');
    int len = strArray.Length;

    for (int i = 0; i < len / 2; i++)
    {
        string temp = strArray[i];

        if (i == 0)
        {
            strArray[i] = strArray[len - 1].Remove(strArray[len - 1].Length - 1);
            //strArray[len - 1] = temp + strArray[len - 1].Substring(strArray[len - 1].Length - 1);
            strArray[len - 1] = string.Concat(temp, strArray[len - 1].AsSpan(strArray[len - 1].Length - 1));
        }
        else
        {
            strArray[i] = strArray[len - 1 - i];
            strArray[len - 1 - i] = temp;
        }
    }

    return string.Join(" ", strArray);
}

Console.WriteLine("Revert Words Order: \n");
Console.WriteLine(RevertWordsOrder("Proin in odio viverra, accumsan purus vel, placerat elit!"));  // elit placerat vel, purus accumsan viverra, odio in Proin!
Console.WriteLine(RevertWordsOrder("Cras iaculis tortor justo."));  // justo tortor iaculis Cras.
Console.WriteLine("\n");

//How Many Occurrences

//Given a string and substring, write a method that returns number of occurrences of substring in the string. Assume that both are case-sensitive. You may need to use library function here.
//Expected input and output
//HowManyOccurrences("do it now", "do") → 1
//HowManyOccurrences("empty", "d") → 0

static int HowManyOccurrences(string str, string subStr)
{
    int found;
    int total = 0;
    for (int i = 0; i < str.Length; i++)
    {
        found = str.IndexOf(subStr, i);

        if (found > -1)
        {
            total++;
            i = found;
        }
    }

    return total;
}

Console.WriteLine("How Many Occurrences: \n");
Console.WriteLine(HowManyOccurrences("He is a good boy, he would never do that!", "he"));  // 1
Console.WriteLine(HowManyOccurrences("104 593 00-930 720193", "93"));  // 3
Console.WriteLine(HowManyOccurrences("xyz", "a"));  // 0
Console.WriteLine("\n");

//Sort Characters Descending

//Given a string, write a method that returns array of chars (ASCII characters) sorted in descending order.
//Expected input and output
//SortCharactersDescending("onomatopoeia") → tpoooonmieaa
//SortCharactersDescending("fohjwf42os") → wsoojhff42

static char[] SortCharactersDescending(string str)
{
    char[] charArray = str.ToCharArray();
    char ch;

    for (int i = 1; i < str.Length; i++)
    {
        for (int j = 0; j < str.Length - 1; j++)
        {
            if (charArray[j] < charArray[j + 1])
            {
                ch = charArray[j];
                charArray[j] = charArray[j + 1];
                charArray[j + 1] = ch;
            }
        }
    }

    return charArray;
}

Console.WriteLine("Sort Characters Descending: \n");
Console.WriteLine(SortCharactersDescending("Aliquam pulvinar aliquam libero, in fringilla erat."));  // vuuutrrrrqqponnnmmlllllliiiiiiigfeebaaaaaaA.,            
Console.WriteLine(SortCharactersDescending("Thi2 12  5@mpl3 Str!nG~"));  // ~trpnmlihTSG@53221!
Console.WriteLine("\n");

//Compress String

//Given a non-empty string, write a method that returns it in compressed format.
//Expected input and output
//CompressString("kkkktttrrrrrrrrrr") → "k4t3r10"
//CompressString("p555ppp7www") → "p153p371w3"

static string CompressString(string str)
{
    var count = 0;
    var last = str[0];
    var newStr = string.Empty;

    foreach (var s in str)
    {
        if (s == last)
        {
            count++;
        }
        else
        {
            newStr += last.ToString() + count;
            last = s;
            count = 1;
        }
    }

    newStr += last.ToString() + count;

    return newStr;
}

Console.WriteLine("Compress String: \n");
Console.WriteLine(CompressString("aaaabbcccccdaa"));  //a4b2c5d1a2
Console.WriteLine(CompressString("948kro"));  //914181k1r1o1
Console.WriteLine(CompressString("$999j*#jjjfYyyy"));  //$193j1*1#1j3f1Y1y3
Console.WriteLine("\n");

//Recursion

//Digits Multiplication
//Given a positive integer, write a method that returns multiplication of all digits in the number.
//Expected input and output
//DigitsMultiplication(456) → 120
//DigitsMultiplication(123) → 6

static int DigitsMultiplication(int num) => num > 10 ? num % 10 * DigitsMultiplication(num / 10) : num % 10;

Console.WriteLine("Digits Multiplication: \n");
Console.WriteLine(DigitsMultiplication(1234));       // 24
Console.WriteLine(DigitsMultiplication(94632));      // 1296
Console.WriteLine(DigitsMultiplication(222222222));  // 512
Console.WriteLine("\n");

//Factorial

//Given a non-negative integer, write a method that returns factorial of a number.
//Expected input and output
//Factorial(4) → 24
//Factorial(7) → 5040

static long Factorial(int num) => num == 0 || num == 1 ? 1 : num * Factorial(num - 1);

Console.WriteLine("Factorial: \n");
Console.WriteLine(Factorial(5));  // 120
Console.WriteLine(Factorial(1));  // 1
Console.WriteLine(Factorial(14)); // 87178291200
Console.WriteLine(Factorial(0));  // 1
Console.WriteLine(Factorial(20)); // 2432902008176640000
Console.WriteLine("\n");

//Fibonacci Number

//Given a non-negative integer, write a method that returns n-th element of Fibonacci sequence.
//Expected input and output
//FibonacciNumber(3) → 2
//FibonacciNumber(7) → 13

static int FibonacciNumber(int num) => num <= 1 ? num : FibonacciNumber(num - 2) + FibonacciNumber(num - 1);

Console.WriteLine("Fibonacci Number: \n");
Console.WriteLine(FibonacciNumber(10));  // 55
Console.WriteLine(FibonacciNumber(0));   // 0
Console.WriteLine(FibonacciNumber(20));  // 6765
Console.WriteLine(FibonacciNumber(13));  // 233
Console.WriteLine("\n");

//Numbers Multiplication

//Given two integers a and b (a <= b) as range, write a method that returns multiplication of numbers from given range.
//Expected input and output
//NumbersMultiplication(5, 7) → 210
//NumbersMultiplication(50, 50) → 50

static int NumbersMultiplication(int from, int to)
{
    while (from == to)
    {
        return from;
    }

    return from * NumbersMultiplication(from + 1, to);
}

Console.WriteLine("Numbers Multiplication: \n");
Console.WriteLine($"{NumbersMultiplication(1, 5)}");     // 120
Console.WriteLine($"{NumbersMultiplication(-27, -22)}"); // 213127200
Console.WriteLine($"{NumbersMultiplication(44, 44)}");   // 44  
Console.WriteLine("\n");

//To The Power Of (Recursion)

//Given two integers, write a method that returns first number raised to the power of second number.
//Expected input and output
//ToThePowerOfRecursion(2, 3) → 8
//ToThePowerOfRecursion(5, 2) → 25

static int ToThePowerOfRecursion(int b, int exp) => exp == 0 ? 1 : exp > 1 ? b * ToThePowerOfRecursion(b, exp - 1) : b;

Console.WriteLine("To The Power Of (Recursion): \n");
Console.WriteLine(ToThePowerOfRecursion(10, 0)); // 1
Console.WriteLine(ToThePowerOfRecursion(3, 7));  // 2187
Console.WriteLine(ToThePowerOfRecursion(2, 10)); // 1024
Console.WriteLine("\n");

//String In Reverse Order(Recursion)

//Given a string, write a method that prints it in reverse order.
//Expected input and output
//StringInReverseOrderRecursion("abcde") → "edcba"
//StringInReverseOrderRecursion("Sed lectus est, elementum ut urna eu") → "ue anru tu mutnemele ,tse sutcel deS"

//static string StringInReverseOrderRecursion(string str) => str.Length > 0 ? str[str.Length - 1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
//static string StringInReverseOrderRecursion(string str) => str.Length > 0 ? str[^1] + StringInReverseOrderRecursion(str.Substring(0, str.Length - 1)) : str;
static string StringInReverseOrderRecursion(string str) => str.Length > 0 ? str[^1] + StringInReverseOrderRecursion(str[0..^1]) : str;

Console.WriteLine("String In Reverse Order(Recursion): \n");
var str1 = "A";
var str2 = "34 ( 9  9@*";
var str3 = "eMpIrE";
var str4 = string.Empty;

Console.WriteLine(StringInReverseOrderRecursion(str1)); // A
Console.WriteLine(StringInReverseOrderRecursion(str2)); // *@9  9 ( 43
Console.WriteLine(StringInReverseOrderRecursion(str3)); // ErIpMe
Console.WriteLine(StringInReverseOrderRecursion(str4)); //
Console.WriteLine("\n");

//Is Palindrome(Recursion)

//Given a string, write a method that checks if it is a palindrome. String length may be >= 0.
//Expected input and output
//IsPalindromeRecursion("xx") → true
//IsPalindromeRecursion("pendrive") → false

static bool IsPalindromeRecursion(string str)
{
    if (str.Length == 1 || (str.Length == 2 && str[0] == str[1]))
    {
        return true;
    }
    else if (str.Length > 1)
    {
        //if (str[0] != str[str.Length - 1])
        if (str[0] != str[^1])
        {
            return false;
        }

        //return IsPalindromeRecursion(str.Substring(1, str.Length - 2));
        return IsPalindromeRecursion(str[1..^1]);
    }

    return false;
}

Console.WriteLine("Is Palindrome(Recursion): \n");
Console.WriteLine(IsPalindromeRecursion("aa"));        // True
Console.WriteLine(IsPalindromeRecursion("dad"));       // True
Console.WriteLine(IsPalindromeRecursion("apple"));     // False
Console.WriteLine(IsPalindromeRecursion("deleveled")); // True
Console.WriteLine(IsPalindromeRecursion(""));          // False
Console.WriteLine(IsPalindromeRecursion("hannah"));    // True
Console.WriteLine(IsPalindromeRecursion("X"));         // True
Console.WriteLine("\n");

//Minimum Element
//Given an array of integers and array's length, write a method that returns its minimum element.
//Expected input and output
//MinimumElement([8, 5, 9], 3) → 5
//MinimumElement([-2, -9, 2, -3, 1, 0], 6) → -9

static int MinimumElement(int[] arr, int size)
{
    if (size == 1)
    {
        return arr[0];
    }

    return arr[size - 1] < MinimumElement(arr, size - 1) ? arr[size - 1] : MinimumElement(arr, size - 1);
}

Console.WriteLine("Minimum Element: \n");
Console.WriteLine(MinimumElement(new int[] { 7, 2, 9, 5, 4 }, 5));                  // 2
Console.WriteLine(MinimumElement(new int[] { -45, -6, 39, 96, -20, 0, -100 }, 7));  // -100
Console.WriteLine(MinimumElement(new int[] { 830, 905, 999, 831, 920, 900 }, 6));   // 830
Console.WriteLine("\n");
