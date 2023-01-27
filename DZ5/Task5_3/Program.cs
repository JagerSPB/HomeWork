using System;

class GFG
{
  static int getSum(int n)
  {
    int sum;

    /* Single line that calculates sum */
    for (sum = 0; n > 0; sum += n % 10, n /= 10)
      ;

    return sum;
  }

  // Driver code
  public static void Main()
  {
    int n = 9112;

    // Function call
    Console.WriteLine("->" + getSum(n));
  }
}