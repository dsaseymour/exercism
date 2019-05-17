using System;

public static class Acronym
{
  public static string Abbreviate(string phrase)
  {
    phrase = phrase.ToUpper();
    phrase = phrase.Replace("-", " ");
    phrase = phrase.Replace("_", String.Empty);
    string[] words = phrase.Split(' ');
    string result = "";
    foreach (string word in words)
    {
      if (string.IsNullOrEmpty(word)) continue;
      result = result + word[0];
    }
    return result;
  }
}