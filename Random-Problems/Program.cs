// See https://aka.ms/new-console-template for more information
using Random_Problems.Problems;
using Random_Problems.Problems.Recursion;

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

var arrayOfPrimes = SieveOfEratosthenes.SieveOfEratosthenesFunc(100);
Console.WriteLine("Sieve of EratosthenesL: \n");

for (int i = 0; i < arrayOfPrimes.Length; i++)
{
    if (arrayOfPrimes[i] != false)
    {
        Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 
    }
}
Console.WriteLine("\n");

DrawHourglass.HourGlassDrawing();

DrawParallelogram.ParallelogramDrawing();

DrawCristmasTree.ChristmasTreeDrawing();

ExtractString.ExtractingString("kFp##jFoRj##pL");

FullSequenceOfLetters.SequenceOfFullLetters("bg"); // bcdefg // "xy" => xy // "az" => abcdefghijklmnopqrstuvwxyz


//Longest Strictly Increasing Sequence

LongestIncreasingSequence.IncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 }); // 4
//LongestIncreasingSequence.IncreasingSequence(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }); // 1
//LongestIncreasingSequence.IncreasingSequence(new int[] { 2, 3, 4, 5, 6, 7, 8 }); // 6
//LongestIncreasingSequence.IncreasingSequence(new int[] { 1, 1, 1, 1, 1, }); // 0

BitsToNumber.BitNumber("0");        // 0
//BitsToNumber.BitNumber("00001011000001");       // 705
//BitsToNumber.BitNumber("10001110001010100");        // 72288

DigitsSum.SumOfDigit(5); // 5
//DigitsSum.SumOfDigit(1029584739); // 48
//DigitsSum.SumOfDigit(99999999); // 72

SumAndAverage.SummationAndAverage(20, 21); // Sum: 41 Average: 20,5
SumAndAverage.SummationAndAverage(55, 55); // Sum: 55 Average: 55
SumAndAverage.SummationAndAverage(0, 100); // Sum: 5050 Average: 50

SumDoubleOnly.DoubleSum(new object[] { 8.9, "dog", 6, 'c', 15.99, 745, true }); // 24.89

DrawTriangle.TriangleDrawing();

ToThePowerOf.PowerToThe(8, -8); // 5.96046447753906E-08
//ToThePowerOf.PowerToThe(5, -2); // 0.04
//ToThePowerOf.PowerToThe(10, 0); // 1
//ToThePowerOf.PowerToThe(0, 5) // 0

LettersBalance.BalanceOfLetters("kfdfdk"); // True
//LettersBalance.BalanceOfLetters("reyjer"); // False
//LettersBalance.BalanceOfLetters("wkxzcsazsckawx"); // True
//LettersBalance.BalanceOfLetters("pkmqsdedeskgqm"); // False

ReplaceTwoWords.WordReplacing("dog_octopus", '_'); // octopus_dog
//ReplaceTwoWords.WordReplacing("a.b", '.'); // b.a
//ReplaceTwoWords.WordReplacing("good very", ' '); // very good

DigitalRoot.DigitalizedRoot(5); // 5
//DigitalRoot.DigitalizedRoot(1029584739); // 3
//DigitalRoot.DigitalizedRoot(99999999); // 9

CheckBracketSequence.BracketsSequence("((()()()))"); // True
//CheckBracketSequence.BracketsSequence(")"); // False
//CheckBracketSequence.BracketsSequence(")(())("); // True
//CheckBracketSequence.BracketsSequence("()())()"); // False
//CheckBracketSequence.BracketsSequence("((()(((()())))())())"); // True

AddSeparator.Separator("computer", "_"); // c_o_m_p_u_t_e_r
//AddSeparator.Separator("$*(#", " "); // $ * ( #
//AddSeparator.Separator("AC", "B"); // ABC
//AddSeparator.Separator("octopus", "X"); // oXcXtXoXpXuXs

Palindrome.IsPalindrome("madam"); // True
//Palindrome.IsPalindrome("123454321"); // True
//Palindrome.IsPalindrome("apple"); // False
//Palindrome.IsPalindrome("Never Odd Or Even"); // True
//Palindrome.IsPalindrome("Curabitur vel est diam"); // False
//Palindrome.IsPalindrome("x"); // True

LengthOfString.StringLength("Lorem ipsum dolor sit amet"); //26
//LengthOfString.StringLength(string.Empty); //0
//LengthOfString.StringLength("conse12ctetur "); //14

StringInReverseOrder.ReverseOrderString("Vivamus commodo quam at purus "); // surup ta mauq odommoc sumaviV
//StringInReverseOrder.ReverseOrderString("34 ( 9  9@*"); // *@9  9 ( 43
//StringInReverseOrder.ReverseOrderString("malesuada"); // adauselam

SumDigitsInString.SumOfStringDigit("aaa5aa5aa5a5a"); // 20
//SumDigitsInString.SumOfStringDigit("10r3m1p5um"); // 10
//SumDigitsInString.SumOfStringDigit("tt"); //0


MakeUpperCase.UpperCaseMaker("very short sentence."); // VeRy ShOrT SeNtEnCe.
//MakeUpperCase.UpperCaseMaker("motorcycle"); // MoToRcYcLe
//MakeUpperCase.UpperCaseMaker("Events And Delegates"); // EvEnTs AnD DeLeGaTeS

MixTwoStrings.StringMixer("DoG", "ElEpHaNt"); // DEolGEpHaNt
//MixTwoStrings.StringMixer("The tallest", "XXXXXXXXXX"); // TXhXeX XtXaXlXlXeXsXt

NumberOfWords.NumOfWords("Mauris consectetur urna sit amet risus ultricies rutrum."); // 8
//NumberOfWords.NumOfWords("Quisque M"); // 2
//NumberOfWords.NumOfWords("Xor"); // 1

RevertWordsOrder.RevertWords("Proin in odio viverra, accumsan purus vel, placerat elit!"); // elit placerat vel, purus accumsan viverra, odio in Proin!
//RevertWordsOrder.RevertWords("Cras iaculis tortor justo."); // justo tortor iaculis Cras.

HowManyOccurrences.Occurrences("He is a good boy, he would never do that!", "he"); // 1
//HowManyOccurrences.Occurrences("104 593 00-930 720193", "93"); // 3
//HowManyOccurrences.Occurrences("xyz", "a"); // 0

SortCharactersDescending.SortByDescending("Aliquam pulvinar aliquam libero, in fringilla erat."); // vuuutrrrrqqponnnmmlllllliiiiiiigfeebaaaaaaA.,            
//SortCharactersDescending.SortByDescending("Thi2 12  5@mpl3 Str!nG~"); // ~trpnmlihTSG@53221!

CompressString.StringCompressing("aaaabbcccccdaa"); //a4b2c5d1a2
CompressString.StringCompressing("948kro"); //914181k1r1o1
CompressString.StringCompressing("$999j*#jjjfYyyy"); //$193j1*1#1j3f1Y1y3

DigitsMultiplication.MultiplicationOfDigits(1234); // 24
//DigitsMultiplication.MultiplicationOfDigits(94632); // 1296
//DigitsMultiplication.MultiplicationOfDigits(222222222); // 512

Factorial.FactorialNumber(5); // 120
//Factorial.FactorialNumber(1); // 1
//Factorial.FactorialNumber(14); // 87178291200
//Factorial.FactorialNumber(0); // 1
//Factorial.FactorialNumber(20); // 2432902008176640000

Fibonacci.FibonacciNumber(10); // 55
//Fibonacci.FibonacciNumber(0); // 0
//Fibonacci.FibonacciNumber(20); // 6765
//Fibonacci.FibonacciNumber(13); // 233

NumbersMultiplication.MultiplicationNumbers(1, 5); // 120
//NumbersMultiplication.MultiplicationNumbers(-27, -22); // 213127200
//NumbersMultiplication.MultiplicationNumbers(44, 44); // 44  

ToThePowerOfRecursion.RecursionPower(10, 0); // 1
//ToThePowerOfRecursion.RecursionPower(3, 7); // 2187
//ToThePowerOfRecursion.RecursionPower(2, 10); // 1024

var str1 = "A";
//var str2 = "34 ( 9  9@*";
//var str3 = "eMpIrE";
//var str4 = string.Empty;

StringInReverseOrderRecursion.RecursionStringInReverseOrder(str1); // A
//StringInReverseOrderRecursion.RecursionStringInReverseOrder(str2); // *@9  9 ( 43
//StringInReverseOrderRecursion.RecursionStringInReverseOrder(str3); // ErIpMe
//StringInReverseOrderRecursion.RecursionStringInReverseOrder(str4); //

RecursionPalindrome.IsPalindromeRecursion("aa"); // True
//RecursionPalindrome.IsPalindromeRecursion("dad"); // True
//RecursionPalindrome.IsPalindromeRecursion("apple"); // False
//RecursionPalindrome.IsPalindromeRecursion("deleveled"); // True
//RecursionPalindrome.IsPalindromeRecursion(""); // False
//RecursionPalindrome.IsPalindromeRecursion("hannah"); // True
//RecursionPalindrome.IsPalindromeRecursion("X"); // True


MinimumElement.MinElement(new int[] { 7, 2, 9, 5, 4 }, 5); // 2
//MinimumElement.MinElement(new int[] { -45, -6, 39, 96, -20, 0, -100 }, 7); // -100
//MinimumElement.MinElement(new int[] { 830, 905, 999, 831, 920, 900 }, 6); // 830

