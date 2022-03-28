namespace Competitive_Programming.Problems;

public static class DigitalRoot
{
    //Given a non-negative number, write a method that returns its digital root. From Wikipedia - digital root is a value obtained by an iterative process of summing digits, on each iteration using the result from the previous iteration to compute a digit sum. The process continues until a single-digit number is reached.
    //Expected input and output
    //DigitalRoot(83) → 2
    //DigitalRoot(40002938) → 8

    public static int DigitalizedRoot(uint number)
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
}
