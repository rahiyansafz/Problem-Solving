namespace Random_Problems.Problems;

public static class DrawCristmasTree
{
    //Write a method that draws Christmas tree shape like below.
    //Expected input and output
    //DrawChristmasTree() →
    //   *
    //  ***
    // *****
    //*******
    //   *
    //  ***
    // *****
    //*******
    //   *
    //  ***
    // *****
    //*******

    public static void ChristmasTreeDrawing()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 7; j += 2)
            {
                for (var k = 0; k < (7 - j) / 2; k++)
                {
                    Console.Write(" ");
                }
                for (var m = 0; m <= j; m++)
                {
                    Console.Write("*");
                }
                for (var n = (7 - j) / 2; n < 7; n++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
