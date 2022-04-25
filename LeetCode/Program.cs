// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;

Console.WriteLine("Hello, LeetCode!");

int[] theArray = { 3, 2, 4 };
int target = 6;

var ret = Solution.TwoSum(theArray, target);

Console.WriteLine("[{0}]", string.Join(", ", ret!));
//Console.WriteLine(string.Join(",", ret!)); // or ret.ToArray()