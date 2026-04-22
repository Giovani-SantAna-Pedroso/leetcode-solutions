// See https://aka.ms/new-console-template for more information
public class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Console.WriteLine("test");

    // hashtable
    //   Dictionary
    //   ConcurrentDictionary
    //   ImmutableDictionary
    string case1 = "III";
    string case2 = "LVIII";
    string case3 = "MCMXCIV";

    static int RomanToInt(string s)
    {

      Dictionary<string, int> values = new();
      values.Add("I", 1);
      values.Add("V", 5);
      values.Add("X", 10);
      values.Add("L", 50);
      values.Add("C", 100);
      values.Add("D", 500);
      values.Add("M", 1000);

      int[] nums = new int[s.Length];
      for (int i = 0; i < s.Length; i++) nums[i] = values[s[i] + ""];
      foreach (int i in nums) Console.WriteLine(i);

      int result = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        if ((i + 1) < nums.Length)
        {
          if (nums[i] < nums[i + 1]) result -= nums[i];
          else result += nums[i];
        }
        else
        {
          result += nums[i];
        }
      }

      return result;
    }

    // Console.WriteLine(RomanToInt(case1));
    // Console.WriteLine(RomanToInt(case2));
    Console.WriteLine(RomanToInt(case3));

  }
}

