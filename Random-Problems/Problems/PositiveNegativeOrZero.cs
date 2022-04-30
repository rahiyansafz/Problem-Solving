namespace Random_Problems.Problems;

public static class PositiveNegativeOrZero
{

    //Given a number, write a method that checks if it is positive, negative or zero.
    //Expected input and output
    //PositiveNegativeOrZero(5.24) → positive
    //PositiveNegativeOrZero(0.0) → zero
    //PositiveNegativeOrZero(-994.53) → negative

    public static string StateOfNumber(double num)
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
}
