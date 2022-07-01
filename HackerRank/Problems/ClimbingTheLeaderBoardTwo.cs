namespace HackerRank.Problems;

public static class ClimbingTheLeaderBoardTwo
{

    // Complete the climbingLeaderboard function below.
    public static int[] ClimbingLeaderboard(int[] ranked, int[] player)
    {
        var distict = ranked.Distinct().ToArray();
        var result = new int[player.Length];
        var comparer = new ReverseComparer<int>();

        for (int index = 0; index < player.Length; index++)
        {
            var search = Array.BinarySearch(distict, player[index], comparer);
            if (search >= 0)
                result[index] = search + 1;
            else
                result[index] = -search;
        }
        return result;
    }

    public class ReverseComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y) => Comparer<T>.Default.Compare(y, x);
    }

    public static void LeaderBoard()
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);
        int scoresCount = Convert.ToInt32(Console.ReadLine()!);
        int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int playerCount = Convert.ToInt32(Console.ReadLine());
        int[] player = Array.ConvertAll(Console.ReadLine()!.Split(' '), playerTemp => Convert.ToInt32(playerTemp));
        int[] result = ClimbingLeaderboard(scores, player);
        textWriter.WriteLine(string.Join("\n", result));
        textWriter.Flush();
        textWriter.Close();
    }
}
