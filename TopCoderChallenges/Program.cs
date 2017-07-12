using System;

namespace TopCoderChallenges
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Top coder - problem 1");
      /*
       You are given two s: N and K. Lun the dog is interested in strings that satisfy the following conditions:
       
      The string has exactly N characters, each of which is either 'A' or 'B'.
       The string s has exactly K pairs (i, j) (0 <= i < j <= N-1) such that s[i] = 'A' and s[j] = 'B'.

      If there exists a string that satisfies the conditions, find and return any such string. Otherwise, return an empty string.
       */

      ReadContinue();
    }

    private static bool ReadContinue()
    {
      Action<string> display = Console.WriteLine;
      display(string.Empty);
      display("Press to exit, any other key to continue...");
      display(string.Empty);
      return Console.ReadKey(true).Key != ConsoleKey.Escape;
    }
  }
}