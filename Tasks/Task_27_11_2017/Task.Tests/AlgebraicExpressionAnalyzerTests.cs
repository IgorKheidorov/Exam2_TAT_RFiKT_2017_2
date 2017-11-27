using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task.Tests
{
  [TestFixture]
  public class AlgebraicExpressionAnalyzerTests
  {
    public Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>()
    {
      {'}','{' },
      {']','[' },
      {')','(' }
    };

    private static string[] sourceInValidExpressions =
    {
      "{", "[", "(", "}", ")","]",
      "{1", "[1", "(1", "1}", "1)","1]","}1", ")1","]1",
      "{)","{]","(}","(]","[}","[)",
      "1{)","1{]","1(}","1(]","1[}","1[)",
      "{1)","{1]","(1}","(1]","[1}","[1)",
      "{)1","{]1","(}1","(]1","[}1","[)1",
      "{([", "{[(", "({[", "([{", "[{(","[{(",
      "{[[(])]}",
      ")(","}{","][",
      ")()(",")[](","){}(",
      "}(){","}[]{","}{}{",
      "]()[","][][","]{}[",

    };


    [Test, TestCaseSource("sourceInValidExpressions")]
    public void IsBracketAlignmentValidInInvalidExpressionFalse(string expression)
    {
      Assert.False(new AlgebraicExpressionAnalyzer().IsBracketAlignmentValid(expression, BracketsDictionary));
    }

  }
}
