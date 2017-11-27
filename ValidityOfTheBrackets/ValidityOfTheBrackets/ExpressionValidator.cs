using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ValidityOfTheBrackets
{
  /// <summary>
  /// This class is checked for correct location of the brackets
  /// </summary>
  class ExpressionValidator
  {
    /// <summary>
    /// This method checks whether the string is empty
    /// </summary>
    /// <param name="algebraicExpression"></param>
    /// <returns>true or false, depending on the outcome</returns>
    public bool IsStringEmpty(string algebraicExpression)
    {
      return (algebraicExpression.Length == 0);
    }

    /// <summary>
    /// This method creates a string that consists of only the parentheses of our algebraic expression
    /// </summary>
    /// <param name="algebraicEpression"></param>
    /// <returns> string that consists of only the parentheses </returns>
    public string DetermineBrackets(string algebraicExpression)
    {
      char[] brackets = { '(', '[', '{', '}', ']', ')' };
      StringBuilder listOfBrackets = new StringBuilder();
      for (int j = 0; j < algebraicExpression.Length; j++)
      {
        for (int i = 0; i < brackets.Length; i++)
        {
          if (algebraicExpression[j] == brackets[i])
          {
            listOfBrackets.Append(algebraicExpression[j]);
          }
        }
      }
      return listOfBrackets.ToString();
    }

    /// <summary>
    /// This method is checked for correct location of the brackets
    /// </summary>
    /// <param name="algebraicEpression"></param>
    /// <returns></returns>
    public bool DetermineTheValidityOfTheBrackets(string algebraicEpression)
    {
      Dictionary<char, char> brackets = new Dictionary<char, char>
      {
        ['['] = ']',
        ['{'] = '}',
        ['('] = ')'
      };
      Stack<char> openingBracketsInExpression = new Stack<char>();
      for (int i = 0; i < algebraicEpression.Length; i++)
      {
        if (brackets.ContainsKey(algebraicEpression[i]))
        {
          openingBracketsInExpression.Push(algebraicEpression[i]);
        }
        else
        {
          brackets.TryGetValue(openingBracketsInExpression.Peek(), out char closeBracket);
          if (closeBracket == algebraicEpression[i])
          {
            openingBracketsInExpression.Pop();
          }
          else
          {
            return false;
          }
        }
      }
      return (openingBracketsInExpression.Count == 0);
    }
  }
}