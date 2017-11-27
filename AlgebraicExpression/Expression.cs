using System.Text;

namespace AlgebraicExpression
{
  /// <summary>
  /// This is class for inputted expression.
  /// </summary>
  public class Expression
  {
    public string InputedExpression { get; private set; }

    /// <summary>
    /// This is constructor for Expression class.
    /// </summary>
    /// <param name="expression"> inputted expression from console </param>
    public Expression(string expression)
    {
      InputedExpression = expression;
    }

    /// <summary>
    /// This method gets brackets from expression.
    /// </summary>
    /// <returns> brackets from expression </returns>
    public string GetBrackets()
    {
      char[] brackets = { '(', ')', '{', '}', '[', ']' };
      StringBuilder bracketsInExpression = new StringBuilder();
      for (int i = 0; i < InputedExpression.Length; i++)
      {
        for (int j = 0; j < brackets.Length; j++)
        {
          if (InputedExpression[i] == brackets[j])
          {
            bracketsInExpression.Append(InputedExpression[i]);
          }
        }
      }
      return bracketsInExpression.ToString();
    }
  }
}