using System;

public static class Grains
{
  public static ulong Square(int n)
  {
    if (n == 1) return 1;
    return 2 * (n - 1);
  }

  public static ulong Total()
  {
    ulong sum = 0;
    var i = 1;
    while (i <= 64)
    {
      sum = sum + Square(i);
      i++;
    }
    return sum;
  }
}