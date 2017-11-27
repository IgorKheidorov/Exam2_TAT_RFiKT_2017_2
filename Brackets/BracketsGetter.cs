using System;
using System.Linq;
using System.Text;

namespace Brackets
{
  /// <summary>
  /// This class is used for manipulate with string to get 
  /// brackets symbols from it.
  /// </summary>
  public class BracketsGetter
  {
    string expression;
    readonly string brackets = "{[()]}";
    public BracketsGetter(string expression)
    {
      this.expression = expression;
    }

    /// <summary>
    /// This method is used for getting the brackets from string.
    /// </summary>
    /// <returns>
    /// Return the string which contains only brackets.
    /// </returns>
    public string GetBrackets()
    {
      StringBuilder bracketsBuilder = new StringBuilder();
      foreach (char symbol in expression)
      {
        if(brackets.Contains(symbol))
        {
          bracketsBuilder.Append(symbol);
        }
      }
      return bracketsBuilder.ToString();
    }
  }
}
