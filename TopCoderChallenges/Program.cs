using System;

namespace TopCoderChallenges
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Top coder - problem's name unknown");
      /*
       You are given two s: N and K. Lun the dog is interested in strings that satisfy the following conditions:
       
      The string has exactly N characters, each of which is either 'A' or 'B'.
       The string s has exactly K pairs (i, j) (0 <= i < j <= N-1) such that s[i] = 'A' and s[j] = 'B'.

      If there exists a string that satisfies the conditions, find and return any such string. Otherwise, return an empty string.
       */

      display("Top coder - Problem Area");
      /*
       Class Name : FarStrings Method Name : find Return Type : String[]Arg Types : (String)
       Problem Area
       Problem Statement
       All strings in this problem are strings of lowercase English letters ('a'-'z').

      Given two strings S and T, their edit distance is defined as the smallest number of steps in which we can change S to T. In each step, we are allowed to make one of the following changes:

      Erasing one arbitrary character of S.
      Inserting one arbitrary character anywhere into S (including its beginning or end).
      Replacing one arbitrary character of S by a different character.
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