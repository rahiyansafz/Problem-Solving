namespace Random_Problems.Problems.Recursion;

public static class Fibonacci
{
    //Given a non-negative integer, write a method that returns n-th element of Fibonacci sequence.
    //Expected input and output
    //FibonacciNumber(3) → 2
    //FibonacciNumber(7) → 13

    public static int FibonacciNumber(int num) => num <= 1 ? num : FibonacciNumber(num - 2) + FibonacciNumber(num - 1);
}
