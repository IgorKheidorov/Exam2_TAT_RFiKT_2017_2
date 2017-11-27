using System;

namespace CheckParentheses
{
  /// <summary>
  /// The entry point of the programm.
  /// </summary>
  public class EntryPoint
  {
    /// <summary>
    /// Call all methods.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        CheckerOfParentheses checker = new CheckerOfParentheses(args[0]);
        Console.WriteLine(checker.CheckerSequence());
      }
      catch (Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
