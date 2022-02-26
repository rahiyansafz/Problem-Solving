﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Competitive Programming");

Console.WriteLine("\n");
Console.WriteLine("\n");

//Add Two Numbers

//Given three numbers, write a method that adds two first ones and multiplies them by a third one.
//Expected input and output
//AddAndMultiply(2, 4, 5) → 30

static double AddAndMultiply(double a, double b, double c) => (a + b) * c;

Console.WriteLine("Add Two Numbers: \n");
Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));
Console.WriteLine("\n");

//Elementary Operations

//Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!
//Expected input and output
//ElementaryOperations(3, 8) → 11, -5, 24, 0.375

static string ElementaryOperations(int a, int b)
{
    int addition = a + b;
    int substraction = a - b;
    int multiplication = a * b;
    double division;

    if (b != 0)
    {
        division = a / (double)b;
    }
    else // assume that division by 0 returns 0
    {
        division = 0;
    }

    return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}");
}

Console.WriteLine("Elementary operations: \n");
Console.WriteLine(ElementaryOperations(1, 2));
Console.WriteLine(ElementaryOperations(-375, 25));
Console.WriteLine("\n");

//Is Result The Same ???

//Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result.
//Expected input and output
//IsResultTheSame(2+2, 2*2) → true
//IsResultTheSame(9 / 3, 16 - 1) → false

static bool IsResultTheSame(double a, double b) => a == b;

Console.WriteLine("Is result the same ???: \n");
Console.WriteLine(IsResultTheSame(3 * 3, 18 / 2));
Console.WriteLine(IsResultTheSame(3 + 7, 12 - 2));
Console.WriteLine("\n");

//Modulo Operations

//Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
//Expected input and output
//ModuloOperations(8, 5, 2) → 1

static int ModuloOperations(int a, int b, int c) => a % b % c;

Console.WriteLine("Modulo operations: \n");
Console.WriteLine(ModuloOperations(542, 28, 7));
Console.WriteLine(ModuloOperations(1, 1, 1));
Console.WriteLine("\n");

//The Cube Of

//Given a number, write a method that returns its cube.
//Expected input and output
//TheCubeOf(2) → 8
//TheCubeOf(-5.5) → -166.375

static double TheCubeOf(double num) => num * num * num;

Console.WriteLine("The cube of: \n");
Console.WriteLine(TheCubeOf(2));
Console.WriteLine(TheCubeOf(3));
Console.WriteLine("\n");

//Swap Two Numbers

//Given two integers, write a method that swaps them using temporary variable.
//Expected input and output
//SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
//SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"

static string SwapTwoNumbers(int a, int b)
{
    string before = $"Before: a = {a}, b = {b}; ";
    int temp;

    temp = b;
    b = a;
    a = temp;

    string after = $"After: a = {a}, b = {b}";
    return before + after;
}

Console.WriteLine("Swap two numbers: \n");
Console.WriteLine(SwapTwoNumbers(23, 15));
Console.WriteLine(SwapTwoNumbers(-123, 999));
Console.WriteLine(SwapTwoNumbers(0, 333));
Console.WriteLine("\n");

//Absolute Value

//Given an integer, write a method that returns its absolute value.
//Expected input and output
//AbsoluteValue(6832) → 6832
//AbsoluteValue(-392) → 392

static int AbsoluteValue(int number) => number >= 0 ? number : number * -1;

Console.WriteLine("Absolute Value: \n");
Console.WriteLine(AbsoluteValue(-999));
Console.WriteLine(AbsoluteValue(9));
Console.WriteLine(AbsoluteValue(0));
Console.WriteLine("\n");

//Divisible By 2 Or 3

//Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
//Expected input and output
//DivisibleBy2Or3(15, 30) → 450
//DivisibleBy2Or3(2, 90) → 180
//DivisibleBy2Or3(7, 12) → 19

static int DivisibleBy2Or3(int a, int b) => (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;

Console.WriteLine("Divisible: \n");
Console.WriteLine(DivisibleBy2Or3(2, 18));   // 36
Console.WriteLine(DivisibleBy2Or3(444, 0));  // 0
Console.WriteLine("\n");

//If Consists Of Uppercase Letters

//Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
//Expected input and output
//IfConsistsOfUppercaseLetters("xyz") → false
//IfConsistsOfUppercaseLetters("DOG") → true
//IfConsistsOfUppercaseLetters("L9#") → false

static bool IfConsistsOfUppercaseLetters(string str) => (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);

Console.WriteLine("Consists of UpperCase: \n");
Console.WriteLine(IfConsistsOfUppercaseLetters("drY"));
Console.WriteLine(IfConsistsOfUppercaseLetters("LOL"));
Console.WriteLine("\n");

//If Greater Than Third One

//Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
//Expected input and output
//IfGreaterThanThirdOne([2, 7, 12]) → true
//IfGreaterThanThirdOne([-5, -8, 50]) → false

static bool IfGreaterThanThirdOne(int[] arr) => arr[0] + arr[1] >= arr[2] || arr[0] * arr[1] > arr[2];

Console.WriteLine("Greater than the third one: \n");
Console.WriteLine(IfGreaterThanThirdOne(new int[] { -15, -25, 100 })); // True
Console.WriteLine(IfGreaterThanThirdOne(new int[] { 11, 15, 166 }));   // False
Console.WriteLine("\n");

//If Number Is Even

//Given an integer, write a method that checks if it is even.
//Expected input and output
//IfNumberIsEven(721) → false
//IfNumberIsEven(1248) → true

static bool IfNumberIsEven(int num) => num % 2 == 0;

Console.WriteLine("Even or not!: \n");
Console.WriteLine(IfNumberIsEven(8));
Console.WriteLine(IfNumberIsEven(54749));
Console.WriteLine(IfNumberIsEven(-43234670));
Console.WriteLine(IfNumberIsEven(0));
Console.WriteLine(IfNumberIsEven(-950541901));
Console.WriteLine(IfNumberIsEven(2140872324));
Console.WriteLine("\n");

//If Sorted Ascending

//Given an array of three integers, write a method that checks if they are sorted in ascending order.
//Expected input and output
//IfSortedAscending([3, 7, 10])→ true
//IfSortedAscending([74, 62, 99])→ false

static bool IfSortedAscending(int[] arr) => arr[0] <= arr[1] && arr[1] <= arr[2];

Console.WriteLine("Sorted Ascending: \n");
Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 })); // True
Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 })); // False
Console.WriteLine(IfSortedAscending(new int[] { -50, -24, -1 })); // True
Console.WriteLine("\n");

//If Has Neighbour

//Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.
//Expected input and output
//IsLonelyIsland("XYZ") → True
//IsLonelyIsland("GWK") → False

Console.WriteLine("Has Neighbour?: \n");

static bool IfHasNeighbour(string word) => word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;

Console.WriteLine(IfHasNeighbour("DCA")); // True
Console.WriteLine(IfHasNeighbour("PRT")); // False
Console.WriteLine("\n");

//Positive, Negative Or Zero

//Given a number, write a method that checks if it is positive, negative or zero.
//Expected input and output
//PositiveNegativeOrZero(5.24) → positive
//PositiveNegativeOrZero(0.0) → zero
//PositiveNegativeOrZero(-994.53) → negative

static string PositiveNegativeOrZero(double num)
{
    if (num > 0.0)
    {
        return "Positive";
    }
    else if (num < 0.0)
    {
        return "Negative";
    }

    return "Zero";
}

Console.WriteLine("Positive, negative or zero??: \n");
Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
Console.WriteLine(PositiveNegativeOrZero(-200.003)); // Negative
Console.WriteLine("\n");

//If Year Is Leap

//Given a year as integer, write a method that checks if year is leap.
//Expected input and output
//IfYearIsLeap(2016) → true
//IfYearIsLeap(2018) → false

static bool IfYearIsLeap(int year) => (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

Console.WriteLine("Leap Year: \n");
Console.WriteLine(IfYearIsLeap(2023));
Console.WriteLine(IfYearIsLeap(2024));
Console.WriteLine("\n");

//If Number Contains 3

//Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.
//Expected input and output
//IfNumberContains3(7201432) → true
//IfNumberContains3(87501) → false

static bool IfNumberContains3(int number)
{
    while (number > 0)
    {
        if (number % 10 == 3)
        {
            return true;
        }
        number /= 10;
    }

    return false;
}

Console.WriteLine("Contains 3: \n");
Console.WriteLine(IfNumberContains3(5384562));
Console.WriteLine(IfNumberContains3(0));
Console.WriteLine(IfNumberContains3(390462));
Console.WriteLine("\n");

//Multiplication Table

//Write a method that prints 10 by 10 multiplication table. Remember about readibility (spaces in the right place).
//Expected input and output
//1  2  3  4  5  6  7  8  9 10
//2  4  6  8 10 12 14 16 18 20
//3  6  9 12 15 18 21 24 27 30
//4  8 12 16 20 24 28 32 36 40
//5 10 15 20 25 30 35 40 45 50
//6 12 18 24 30 36 42 48 54 60
//7 14 21 28 35 42 49 56 63 70
//8 16 24 32 40 48 56 64 72 80
//9 18 27 36 45 54 63 72 81 90
//10 20 30 40 50 60 70 80 90 100

static void MultiplicationTable()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            if (i == 1)
            {
                if (i * j < 10)
                {
                    Console.Write($" {i * j} ");
                }
                else
                {
                    Console.Write($"{i * j} ");
                }
            }
            else if (i > 1 && i < 10)
            {
                if (i * j < 10)
                {
                    Console.Write($" {i * j} ");
                }
                else
                {
                    Console.Write($"{i * j} ");
                }
            }
            else
            {
                Console.Write($"{i * j} ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Multiplication Table: \n");
MultiplicationTable();
Console.WriteLine("\n");

//Fractions Sum

//Given an integer n, write a method that returns sum of series 1 + (½)² +(⅓)² +... +(1⁄n)². Do not use library function!
//Expected input and output
//FractionsSum(3) → 1.36111111111111
//FractionsSum(5) → 1.46361111111111

static double FractionsSum(int num)
{
    double sum = 0.0;
    for (int i = 1; i <= num; i++)
    {
        sum += (1 / (double)(i * i));
    }

    return sum;
}

Console.WriteLine("Fractions Sum: \n");
Console.WriteLine(FractionsSum(2));  // 1.25
Console.WriteLine(FractionsSum(7));  // 1.5117970521542
Console.WriteLine(FractionsSum(10)); // 1.54976773116654
Console.WriteLine("\n");

//Sort array ascending

//Given an array of integers, write a method that returns sorted array in ascending order.
//Expected input and output
//SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9] 

static int[] SortArrayAscending(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }
    }

    return arr;
}

int[] sortedArr = SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });
Console.WriteLine("Sort Array Ascending: \n");

foreach (var s in sortedArr)
{
    Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
}
Console.WriteLine("\n");

//The biggest number

//Given an array of integers, write a method that returns the biggest number in this array.
//Expected input and output
//TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 291
//TheBiggestNumber([-9, -2, -7, -8, -4]) → -2

static int TheBiggestNumber(int[] numArr)
{
    int theBiggest = numArr[0];

    for (int i = 1; i < numArr.Length; i++)
    {
        if (numArr[i] > theBiggest)
        {
            theBiggest = numArr[i];
        }
    }

    return theBiggest;
}

Console.WriteLine("The Biggest Number: \n");
Console.WriteLine(TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));                   // 9
Console.WriteLine(TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));       // -7
Console.WriteLine(TheBiggestNumber(new int[] { 1009, 998, 1090, 3000, 2934, 4888 }));  // 4888
Console.WriteLine("\n");

//Two 7s next to each other

//Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
//Expected input and output
//Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 
//Two7sNextToEachOther([9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7]) → 3

static int Two7sNextToEachOther(int[] arr)
{
    int adjacent7s = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == 7 && arr[i + 1] == 7)
        {
            adjacent7s++;
        }
    }

    return adjacent7s;
}

Console.WriteLine("Two 7s Next to Each Other: \n");
Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));           // 1
Console.WriteLine(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));           // 0      
Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));  // 3
Console.WriteLine("\n");

//Three increasing adjacent

//Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.
//Expected input and output
//ThreeIncreasingAdjacent([45, 23, 44, 68, 65, 70, 80, 81, 82 ]) → True
//ThreeIncreasingAdjacent([7, 3, 5, 8, 9, 3, 1, 4 ]) → False

static bool ThreeIncreasingAdjacent(int[] arr)
{
    bool found = false;
    for (int i = 1; i <= arr.Length - 2; i++)
    {
        if (arr[i - 1] + 1 == arr[i] && arr[i + 1] - 1 == arr[i])
        {
            found = true;
        }
    }

    return found;
}

Console.WriteLine("Three Increasing Adjacent");
Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));                // True
Console.WriteLine(ThreeIncreasingAdjacent(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 }));       // True
Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 15, 17, 14, 11, 18, 19, 16, 16 }));     // False
Console.WriteLine("\n");

//Return even numbers

//Write a method that returns a string of even numbers greater than 0 and less than 100.
//Expected input and output
//ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"


static string ReturnEvenNumbers()
{
    string str = string.Empty;
    for (int i = 1; i < 100; i++)
    {
        if (i % 2 == 0)
        {
            str += i + " ";
        }
    }

    return str;
}

Console.WriteLine("Return Even Numbers: \n");
Console.WriteLine(ReturnEvenNumbers());
Console.WriteLine("\n");

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

//Draw hourglass
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

//Draw parallelogram

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

Console.WriteLine("Draw parallelogram: \n");
DrawParallelogram();
Console.WriteLine("\n");

//Draw Christmas tree

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

//Extract string

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

Console.WriteLine("Extract string: \n");
Console.WriteLine(ExtractString("kFp##jFoRj##pL")); // jFoRj
Console.WriteLine(ExtractString("abc##def"));       // /empty string/
Console.WriteLine(ExtractString("##123456789##"));  // 123456789
Console.WriteLine(ExtractString("no####thing"));    // /empty string/
Console.WriteLine(ExtractString("empty"));          // /empty string/
Console.WriteLine("\n");

//Full sequence of letters

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

Console.WriteLine("Full sequence of letters: \n");
Console.WriteLine(FullSequenceOfLetters("bg")); // bcdefg
Console.WriteLine(FullSequenceOfLetters("xy")); // xy            
Console.WriteLine(FullSequenceOfLetters("az")); // abcdefghijklmnopqrstuvwxyz
Console.WriteLine("\n");


//Longest strictly increasing sequence

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


Console.WriteLine("Longest strictly increasing sequence: \n");
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 })); // 4
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 })); // 1
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 })); // 6
Console.WriteLine(LongestStrictlyIncreasingSequence(new int[] { 1, 1, 1, 1, 1, })); // 0
Console.WriteLine("\n");

//Bits to number

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

Console.WriteLine("Bits to number: \n");
Console.WriteLine(BitsToNumber("0"));                   // 0
Console.WriteLine(BitsToNumber("00001011000001"));      // 705
Console.WriteLine(BitsToNumber("10001110001010100"));   // 72288
Console.WriteLine("\n");

//Digits sum

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

//Sum and average

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

Console.WriteLine("Sum and Average: \n");
Console.WriteLine(SumAndAverage(20, 21)); // Sum: 41 Average: 20,5
Console.WriteLine(SumAndAverage(55, 55)); // Sum: 55 Average: 55
Console.WriteLine(SumAndAverage(0, 100)); // Sum: 5050 Average: 50
Console.WriteLine("\n");

//Sum double only

//Given an array of objects, write a method that returns sum of objects of double type.
//Expected input and output
//SumDoubleOnly(["abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22]) → 7.82

static double SumDoubleOnly(object[] obj)
{
    double sum = 0.0;
    for (int i = 0; i < obj.Length; i++)
    {
        if (obj[i] is double)
        {
            sum += (double)obj[i];
        }
    }

    return sum;
}

Console.WriteLine("Sum Double Only: \n");
Console.WriteLine(SumDoubleOnly(new object[] { 8.9, "dog", 6, 'c', 15.99, 745, true })); // 24.89
Console.WriteLine("\n");

//Draw triangle

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