using System;

namespace CanSecondStringConsistsFromFirstString
{
  public class Program
  {
    static void Main(string[] args)
    {
      try
      {
        CheckerOnCanSecondStringConsistsSymbolsOfFirst checkerOnCanSecondStringConsistsSymbolsOfFirst = new CheckerOnCanSecondStringConsistsSymbolsOfFirst(args[0], args[1]);
        Console.WriteLine(checkerOnCanSecondStringConsistsSymbolsOfFirst.CheckOnSecondStringHasAllSymbolsOfFirst());
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
