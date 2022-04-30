namespace Random_Problems.Problems.Recursion;

public static class NumbersMultiplication
{
    //Given two integers a and b (a <= b) as range, write a method that returns multiplication of numbers from given range.
    //Expected input and output
    //NumbersMultiplication(5, 7) → 210
    //NumbersMultiplication(50, 50) → 50

    public static int MultiplicationNumbers(int from, int to)
    {
        while (from == to)
        {
            return from;
        }

        return from * MultiplicationNumbers(from + 1, to);
    }
}
