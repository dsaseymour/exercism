using System;

public static class Gigasecond
{
  //A gigasecond is 10^9 (1,000,000,000) seconds.
  public static DateTime Add(DateTime moment)
  {
    return moment.AddSeconds(1000000000);


  }
}