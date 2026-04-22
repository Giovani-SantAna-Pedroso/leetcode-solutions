class Tests
{
  public int[] samples;
  public int target;
}

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Tests test1 = new Tests();
    test1.samples = new int[] { 0, 4, 3, 0 };
    test1.target = 0;

    var result = TwoSum(test1.samples, test1.target);
    Console.WriteLine(result[1] + ", " + result[0]);
  }

  static public int[] TwoSum(int[] nums, int target)
  {
    var sortedNums = new int[nums.Length];
    Array.Copy(nums, sortedNums, nums.Length);
    Array.Sort(sortedNums);
    // var sortedNums = nums.Where(x => x < target).ToArray();
    for (int i = 0; i < sortedNums.Length; i++)
    {
      for (int j = (i + 1); j < sortedNums.Length; j++)
      {
        if ((sortedNums[i] + sortedNums[j]) == target)
        {
          int firstIndex = Array.IndexOf(nums, sortedNums[j]);
          if (sortedNums[i] == sortedNums[j])
          {
            nums[firstIndex] = sortedNums[i] + 1;
          }
          Console.WriteLine(sortedNums[i] + " " + nums[firstIndex]);
          int secondIndex = Array.IndexOf(nums, sortedNums[i]);
          Console.WriteLine(sortedNums[j]);
          return [firstIndex, secondIndex];
        }
      }

    }
    return [0, 0];

  }
}
