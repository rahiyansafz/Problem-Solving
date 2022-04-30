namespace Random_Problems.Problems;

public static class SwapTwoNumbers
{
    //Given two integers, write a method that swaps them using temporary variable.
    //Expected input and output
    //SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
    //SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"

    public static string Swap(int a, int b)
    {
        string before = $"Before: a = {a}, b = {b}; ";
        int temp;

        temp = b;
        b = a;
        a = temp;

        string after = $"After: a = {a}, b = {b}";
        return before + after;
    }
}
