using System.Collections.Generic;

namespace AlgebraicExpression
{
  /// <summary>
  /// This is the class for checking expressions.
  /// </summary>
  public class BracketsChecker
  {
    public string BracketsInExpression { get; private set; }

    /// <summary>
    /// This is constructor for ExpressionChecker class.
    /// </summary>
    /// <param name="expression"> inputted expression from console </param>
    public BracketsChecker(string bracketsInExpression)
    {
      BracketsInExpression = bracketsInExpression;
    }

    /// <summary>
    /// This method checks if brackets are correct in expression.
    /// </summary>
    /// <returns> true if brackets are correct </returns>
    public bool CheckBrackets()
    {
      Dictionary<char, char> brackets = new Dictionary<char, char>
      {
        ['['] = ']',
        ['{'] = '}',
        ['('] = ')'
      };
      Stack<char> openingBracketsInExpression = new Stack<char>();
      for (int i = 0; i < BracketsInExpression.Length; i++)
      {
        if (brackets.ContainsKey(BracketsInExpression[i]))
        {
          openingBracketsInExpression.Push(BracketsInExpression[i]);
        }
        else
        {
          brackets.TryGetValue(openingBracketsInExpression.Peek(), out char closingBracket);
          if (closingBracket == BracketsInExpression[i])
          {
            openingBracketsInExpression.Pop();
          }
          else
          {
            return false;
          }
        }
      }
      return openingBracketsInExpression.Count == 0;
    }
  }
}