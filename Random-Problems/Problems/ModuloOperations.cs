namespace Random_Problems.Problems;

public static class ModuloOperations
{
    //Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
    //Expected input and output
    //ModuloOperations(8, 5, 2) → 1

    public static int ModOperations(int a, int b, int c) => a % b % c;

}
