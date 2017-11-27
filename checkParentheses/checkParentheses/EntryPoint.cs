using System;

namespace CheckParentheses
{
  /// <summary>
  /// The entry point of the programm.
  /// </summary>
  public class EntryPoint
  {
    const string INPUTSEQUENCE = "Enter your sequence:\n >>";

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        // Console.Write(INPUTSEQUENCE);
        //string stringForChecking = "((()]))";
        //Console.ReadLine()
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
