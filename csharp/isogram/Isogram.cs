using System;
using System.Collections.Generic;
public static class Isogram
{
  public static bool IsIsogram(string word)
  {
    Dictionary<char, char> dictionary = new Dictionary<char, char>();
    //convert all to lowercase
    word = word.ToLower();
    foreach (char letter in word)
    {
      //ignore hyphens and equals during comparison
      if (letter.Equals('-') || letter.Equals(' ')) { continue; }
      //if the dictionary already contains this letter then this is not an isogram because it has a duplicate
      if (dictionary.ContainsKey(letter)) { return false; }
      dictionary.Add(letter, letter);
    }
    //this is an isogram, no duplicates. 
    return true;
  }
}
