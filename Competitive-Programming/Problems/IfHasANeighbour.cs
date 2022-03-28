namespace Competitive_Programming.Problems;

public static class IfHasANeighbour
{
    //Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.
    //Expected input and output
    //IsLonelyIsland("XYZ") → True
    //IsLonelyIsland("GWK") → False

    public static bool HasNeighbour(string word) => word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;

}
