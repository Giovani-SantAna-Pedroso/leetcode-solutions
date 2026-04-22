// See https://aka.ms/new-console-template for more information
Console.Clear();


bool IsPalindrome(int x)
{
  string num = String.Format("{0}", x); char[] charArr = num.ToCharArray();
  Array.Reverse(charArr);
  string reversed = new string(charArr);

  return num.Equals(reversed);
}

Console.WriteLine("121 is a palindromte " + IsPalindrome(121));
Console.WriteLine("-121 is a palindromte " + IsPalindrome(-121));
Console.WriteLine("10 is a palindromte " + IsPalindrome(10));
