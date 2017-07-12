using System;

namespace TopCoderChallenges
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;

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