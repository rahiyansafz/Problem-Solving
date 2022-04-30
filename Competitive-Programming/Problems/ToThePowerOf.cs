namespace Random_Problems.Problems;

public static class ToThePowerOf
{
    //Given two integers, write a method that returns first number raised to the power of second one.
    //Expected input and output
    //ToThePowerOf(-2, 3) → -8
    //ToThePowerOf(5, 5) → 3125

    public static double PowerToThe(int b, int exp)
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
}
