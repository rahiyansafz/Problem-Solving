namespace Random_Problems.Problems;

public static class ContainingThree
{
    //Write a method that checks if given number (positive integer) contains digit 3. Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.
    //Expected input and output
    //IfNumberContains3(7201432) → true
    //IfNumberContains3(87501) → false

    public static bool IsContainThree(int number)
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
}
