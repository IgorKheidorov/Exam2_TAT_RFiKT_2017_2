using System;
using System.Collections.Generic;
using System.Linq;

namespace Brackets
{
  public class BracketsValidator 
  {
    string expression;
    string bracketsFromExpression;
    Dictionary<char, char> brackets = new Dictionary<char, char>
    {
      {'{','}'},
      {'(',')'},
      {'[',']'}
    };
    Stack<char> stackOfBrackets = new Stack<char>();

    public BracketsValidator(string expression)
    {
      this.expression = expression;
      bracketsFromExpression = new BracketsGetter(expression).GetBrackets();
    }

    public bool ValidateExpression()
    {
      bool isValid = true;
      if (bracketsFromExpression.Length < 2)
      {
        return false;
      }
      for (int i = 0; i < bracketsFromExpression.Length; i++)
      {
        if (brackets.ContainsKey(bracketsFromExpression[i]))
        {
          stackOfBrackets.Push(bracketsFromExpression[i]);
        }
        else if (brackets.ContainsValue(bracketsFromExpression[i]))
        {
          if (stackOfBrackets.Count != 0)
          {
            char c = stackOfBrackets.Pop();
            if (brackets[c] != bracketsFromExpression[i])
            {
              isValid = false;
              break;
            }
          }
          else
          {
            isValid = false;
            break;
          }
        }
      }
      if (stackOfBrackets.Count != 0)
      {
        isValid = false;
      }
      return isValid;
    }

  }
}
