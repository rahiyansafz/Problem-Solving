namespace LeetCode.Problems._35._Search_Insert_Position;

public class SearchInsertPos
{
    public int SearchInsert(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length;
        while (lo < hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] < target) lo = mid + 1;
            else hi = mid;
        }
        return lo;
    }
}

// Runtime => 165 ms
// Memory Usage => 7.7 MB

// ---

// Approach 2

public class SearchInsertPos2
{
    public int SearchInsert(int[] nums, int target)
    {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }
    public int BinarySearch(int[] nums, int lo, int hi, int item)
    {
        if (lo > hi)
            return lo; // Location where would be
        int mid = (lo + hi) / 2;
        if (nums[mid] == item) return mid;
        if (nums[mid] < item)
            lo = mid + 1;
        else
            hi = mid - 1;
        return BinarySearch(nums, lo, hi, item);
    }

    //int[] data = { 1, 3, 5, 6 };
    //int target = 0;
    //Console.WriteLine(new Solution().SearchInsert(data, target));
    //Console.ReadKey();
    //Console.WriteLine("Hello World!");
}