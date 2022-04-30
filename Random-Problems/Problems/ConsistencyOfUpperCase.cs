namespace Random_Problems.Problems;

public static class ConsistencyOfUpperCase
{
    //Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
    //Expected input and output
    //IfConsistsOfUppercaseLetters("xyz") → false
    //IfConsistsOfUppercaseLetters("DOG") → true
    //IfConsistsOfUppercaseLetters("L9#") → false
    public static bool IfConsistsOfUppercaseLetters(string str) => (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);

}
