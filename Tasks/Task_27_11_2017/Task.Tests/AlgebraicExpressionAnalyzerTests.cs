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

    private static string[] sourceValidExpressions =
    {
      "", " ", "123","1+2+3",
      "[1]","(1)","{1}",
      "(())","([])","({})",
      "((1+2))","([1+2])","({1+2})",
      "{()}","{[]}","{{}}",
      "{(1+2)}","{[1+2]}","{{1+2}}",
      "[()]","[[]]","[{}]",
      "[(1+2)]","[[1+2]]","[{1+2}]",
    };


    [Test, TestCaseSource("sourceInValidExpressions")]
    public void IsBracketAlignmentValidInInvalidExpressionFalse(string expression)
    {
      Assert.False(new AlgebraicExpressionAnalyzer().IsBracketAlignmentValid(expression, BracketsDictionary));
    }

    [Test, TestCaseSource("sourceValidExpressions")]
    public void IsBracketAlignmentValidInValidExpressionTrue(string expression)
    {
      Assert.True(new AlgebraicExpressionAnalyzer().IsBracketAlignmentValid(expression, BracketsDictionary));
    }

  }
}
