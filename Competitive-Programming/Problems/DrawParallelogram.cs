namespace Competitive_Programming.Problems;

public static class DrawParallelogram
{
    //Write a method that draws parallelogram shape like below.
    //Expected input and output
    //DrawParallelogram() →
    //     ***************
    //    ***************
    //   ***************
    //  ***************
    // ***************

    public static void ParallelogramDrawing()
    {
        for (var j = 0; j < 5; j++)
        {
            for (var k = 0; k < 5 - j; k++)
            {
                Console.Write(" ");
            }
            for (var m = 0; m < 15; m++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
