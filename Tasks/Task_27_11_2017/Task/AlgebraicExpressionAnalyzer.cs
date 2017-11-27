using System.Collections.Generic;

namespace Task
{
  /// <summary>
  /// Class contains main method to verifies the expression
  /// and help methods for implementing this logic
  /// </summary>
  public class AlgebraicExpressionAnalyzer
  {
    /// <summary>
    /// Method verifies the expression
    /// to correct parentheses
    /// </summary>
    /// <param name="expression">inputed expression</param>
    /// <param name="bracketsDictionary">possible brackets</param>
    /// <returns>true if brackets aligment valid, false otherwise</returns>
    public bool IsBracketAlignmentValid(string expression, Dictionary<char, char> bracketsDictionary)
    {
      List<char> bracketsInExpression = GetListWithBracketsInExpression(expression, bracketsDictionary);

      if (bracketsInExpression.Count % 2 != 0)
      {
        return false;
      }

      if (bracketsInExpression.Count == 0)
      {
        return true;
      }

      if (!IsPossibleFillStack(bracketsInExpression, bracketsDictionary)) return false;
      return true;
    }

    /// <summary>
    /// Method implements logic of validation brackets aligment
    /// using the stack
    /// </summary>
    /// <param name="bracketsInExpression">list brackets in inputed expression</param>
    /// <param name="bracketsDictionary">possible brackets</param>
    /// <returns>true if , false otherwise</returns>
    private bool IsPossibleFillStack(List<char> bracketsInExpression, Dictionary<char, char> bracketsDictionary)
    {
      Stack<char> bracketsStack = new Stack<char>();
      foreach (var elem in bracketsInExpression)
      {
        // Push open bracket
        if (bracketsDictionary.ContainsValue(elem))
        {
          bracketsStack.Push(elem);
          continue;
        }
        // Try pop open bracket
        if (bracketsDictionary.ContainsKey(elem))
        {
          if (bracketsStack.Count !=0 && bracketsStack.Peek().Equals(bracketsDictionary[elem]))
          {
            bracketsStack.Pop();
          }
          else return false;
        }
      }
      return true;
    }

    /// <summary>
    /// Method returns only brackets from expression
    /// </summary>
    /// <param name="expression">input expression</param>
    /// <param name="bracketsDictionary">possible brackets</param>
    /// <returns>List with brackets in inputed expression</returns>
    private List<char> GetListWithBracketsInExpression(string expression, Dictionary<char, char> bracketsDictionary)
    {
      List<char> bracketsInExpression = new List<char>();

      foreach (var elem in expression)
      {
        if (bracketsDictionary.ContainsKey(elem) || bracketsDictionary.ContainsValue(elem))
        {
          bracketsInExpression.Add(elem);
        }
      }
      return bracketsInExpression;
    }

  }
}
