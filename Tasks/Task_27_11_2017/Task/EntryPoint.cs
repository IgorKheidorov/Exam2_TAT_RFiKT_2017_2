using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Task
{
  /// <summary>
  /// Main method of class calls expression analyzer
  /// to analyze input in command line exppression
  /// </summary>
  public class EntryPoint
  {
    private const string ValidExpression = "Valid expression";
    private const string InvlidExpression = "Invalid expression";

    /// <summary>
    /// Method passes the first argument to the command line
    /// and gives the result of the analysis of the arrangement of the brackets
    /// described in the dictionary
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      Dictionary<char, char> bracketsDictionary = new Dictionary<char, char>()
      {
        {'}','{' },
        {']','[' },
        {')','(' }
      };
      string result = new AlgebraicExpressionAnalyzer()
        .IsBracketAlignmentValid(args[0], bracketsDictionary) ? ValidExpression : InvlidExpression;
      Console.WriteLine(result);
    }
  }
}
