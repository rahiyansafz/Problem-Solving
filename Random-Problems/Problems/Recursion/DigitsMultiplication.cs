namespace Random_Problems.Problems.Recursion;

public static class DigitsMultiplication
{
    //Digits Multiplication
    //Given a positive integer, write a method that returns multiplication of all digits in the number.
    //Expected input and output
    //DigitsMultiplication(456) → 120
    //DigitsMultiplication(123) → 6

    public static int MultiplicationOfDigits(int num) => num > 10 ? num % 10 * MultiplicationOfDigits(num / 10) : num % 10;
}
