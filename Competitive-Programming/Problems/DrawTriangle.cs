namespace Random_Problems.Problems;

public static class DrawTriangle
{
    //Write a method that draws triangle shape like below.
    //Expected input and output
    // DrawTriangle() →
    //         *
    //        **
    //       ***
    //      ****
    //     *****
    //    ******
    //   *******
    //  ********
    // *********
    //**********

    public static void TriangleDrawing()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 10; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 10; k >= 10 - i; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}
