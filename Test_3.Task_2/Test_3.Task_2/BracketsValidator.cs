using System.Collections.Generic;

namespace Test_3.Task_2
{
  /// <summary>
  /// Class checks correct brackets alignment.
  /// </summary>
  public class BracketsValidator
  {
    private const string openingBrackets = "([{";
    private const string closingBrackets = ")]}";
    Stack<char> bracketsStack = new Stack<char>();

    /// <summary>
    /// Method checks correct brackets alignment.
    /// </summary>
    /// <param name="text">Entered string, which needs check brackets.</param>
    /// <returns>Returns true, if brackets are arranged correctly. And false if not.</returns>
    public bool CheckBracketsAlignment(string text)
    {
      foreach (char bracket in text)
      {
        if (bracket == openingBrackets[0]
          || bracket == openingBrackets[1]
          || bracket == openingBrackets[2])
        {
          bracketsStack.Push(bracket);
        }

        if ((bracket == closingBrackets[0]
          || bracket == closingBrackets[1]
          || bracket == closingBrackets[2] && bracketsStack.Count != 0)
          && !CompareBrackets(bracketsStack.Peek(), bracket))
        {
          return false;
        }

        if ((bracket == closingBrackets[0]
          || bracket == closingBrackets[1]
          || bracket == closingBrackets[2]) && text.Length == 1)
        {
          return false;
        }
      }

      if (bracketsStack.Count == 0)
      {
        return true;
      }
      return false;
    }

    private bool CompareBrackets(char openingBracket, char closingBracket)
    {
      for (int i = 0; i < openingBrackets.Length; i++)
      {
        if (openingBracket == openingBrackets[i] && closingBracket == closingBrackets[i])
        {
          bracketsStack.Pop();
          return true;
        }
      }
      return false;
    }
  }
}
