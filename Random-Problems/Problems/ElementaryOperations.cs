namespace Random_Problems.Problems;

public static class ElementaryOperations
{
    public static string EOperations(int a, int b)
    {
        //Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division. Remember that you can't divide any number by 0!
        //Expected input and output
        //ElementaryOperations(3, 8) → 11, -5, 24, 0.375

        int addition = a + b;
        int substraction = a - b;
        int multiplication = a * b;
        double division = b != 0 ? a / (double)b : 0;
        return String.Format($"a + b = {addition}, a - b = {substraction}, a * b = {multiplication}, a / b = {division}");
    }
}
