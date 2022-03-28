namespace Competitive_Programming.Problems;

public static class ReturnEvenNumbers
{
    //Write a method that returns a string of even numbers greater than 0 and less than 100.
    //Expected input and output
    //ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"

    public static string EvenNumbers()
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
}
