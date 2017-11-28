using System.Collections.Generic;

namespace TaskAboutBrackets
{
  /// <summary>
  /// Validates string with algebraic expressions.
  /// </summary>
  public class StringValidator
  {
    private List<char> openingBrackets = new List<char>() {'(', '{', '['};
    private List<char> closingBrackets = new List<char>() { ')', '}', ']'};

    private char ReverseBracket(char bracket)
    {
      if (openingBrackets.Contains(bracket))
      {
        return closingBrackets[openingBrackets.IndexOf(bracket)];
      }
      else
      {
        return openingBrackets[closingBrackets.IndexOf(bracket)];
      }
    }

    /// <summary>
    /// Validates string with algebraic expressions.
    /// </summary>
    /// <param name="str">String to analyze.</param>
    /// <returns>True if brackets in string with valid alignment.False otherwise.</returns>
    public bool StringIsValid(string str)
    {
      Stack<char> brackets = new Stack<char>();        
      for (int i = 0; i < str.Length; i++)
      {
        if (openingBrackets.Contains(str[i]))
        {
          brackets.Push(str[i]);
        }
        if (brackets.Count > 0)
        {
          if (closingBrackets.Contains(str[i]) && str[i] == ReverseBracket(brackets.Peek()))
          {                       
            brackets.Pop();
          }           
        }
        else if (closingBrackets.Contains(str[i]))
        {
          return false;
        }
      }
      return brackets.Count == 0;           
    }       
  }
}
