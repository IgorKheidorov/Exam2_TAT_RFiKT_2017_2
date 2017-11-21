using System;

namespace CheckOnIntegerInputString
{
  /*
   * This program check input string on is it integer value and return int.
   */

  public class Program
  {
    static void Main(string[] args)
    {
      try
      {
        CheckerOnIntegerInputData checkerOnIntegerInputData = new CheckerOnIntegerInputData(args[0]);
        Console.WriteLine(checkerOnIntegerInputData.CreateIntIfStringIsInt());
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
