using System;

public static class Leap
{
  public static bool IsLeapYear(int year)
  {
    //Every year divisible by 4
    //except every year also divisible by 100
    //unless it is also divisible by 400
return (year%100==0)?(year % 4 == 0 && year % 400 == 0):(year % 4 == 0);

  }
} 