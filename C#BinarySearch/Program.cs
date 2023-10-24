class Program
{
    static bool SearchBin(int[] mass, int target)
    {
        int left = 0;
        int right = mass.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mass[mid] == target)
                return true;

            else if (mass[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 5, 6 };
        int target = 5;
        bool isFound = SearchBin(nums, target);
        Console.WriteLine(isFound);
    }
}