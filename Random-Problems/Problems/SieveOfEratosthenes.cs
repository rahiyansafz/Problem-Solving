namespace Random_Problems.Problems;

public static class SieveOfEratosthenes
{
    //Given an integer n (n>2), write a method that returns prime numbers from range [2, n].
    //Expected input and output
    //SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29] 

    public static bool[] SieveOfEratosthenesFunc(int n)
    {
        bool[] array = new bool[n];

        for (int i = 2; i < n; i++)
        {
            array[i] = true;
        }

        for (int j = 2; j * j <= n; j++)
        {
            if (array[j] == true)
            {
                for (int k = j * j; k < n; k += j)
                {
                    array[k] = false;
                }
            }
        }
        return array;
    }
}
