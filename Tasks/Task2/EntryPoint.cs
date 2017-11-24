using System;

namespace Task2
{
  /// <summary>
  /// 
  /// </summary>
  public class EntryPoint
  {
    private const string Possible = "Possible";
    private const string Inpossible = "Inpossible";

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      string result = new StringsAnalyzer()
        .IsPossibleCreateFirstStringFromElemsFromSecond("abcdef1", "fedcba") ? Possible : Inpossible;
      Console.WriteLine(result);
    }
  }
}
