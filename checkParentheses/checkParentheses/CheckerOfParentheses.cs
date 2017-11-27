using System;
using System.Collections.Generic;

namespace CheckParentheses
{
  public class CheckerOfParentheses
  {
    private string inputSequence;
    const int KINDOFBRACKETS = 3;

    /// <summary>
    /// Also throw exception if the string is empty.
    /// </summary>
    public string InputSequence
    {
      get
      {
        return inputSequence;
      }
      set
      {
        inputSequence = value;
        if (string.IsNullOrEmpty(inputSequence))
        {
          throw new Exception("Your sequence is null.");
        }
      }
    }

    Dictionary<char, char> dictionaryOfBackets;

    //public Dictionary<char> 
    /// <summary>
    /// Trivial constructor with field and dictionaryOfBackets initialization.
    /// </summary>
    /// <param name="sequence"></param>
    public CheckerOfParentheses(string sequence)
    {
      InputSequence = sequence;
      dictionaryOfBackets = new Dictionary<char, char>(KINDOFBRACKETS);
      dictionaryOfBackets.Add('{', '}');
      dictionaryOfBackets.Add('[', ']');
      dictionaryOfBackets.Add('(', ')');
    }

    /// <summary>
    /// Check: if the first closed bracket is equals  to the last opened bracket in dictionary.
    /// </summary>
    /// <returns>
    /// True if stack consists of zero elements => srtring is valid.
    /// </returns>
    public bool CheckerSequence()
    {
      Stack<char> stackWithOpenedBracket = new Stack<char>();
      for (int i = 0; i < InputSequence.Length; i++)
      {
        if (dictionaryOfBackets.ContainsKey(InputSequence[i]))
        {
          stackWithOpenedBracket.Push(InputSequence[i]);
        }
        else if (СompareSymbols(stackWithOpenedBracket))
        {
          stackWithOpenedBracket.Pop();
        }
        else
        {
          return false;
        }
      }
      return stackWithOpenedBracket.Count == 0;
    }

    /// <summary>
    /// If first index is equals  to the last opened bracket in dictionary.
    /// </summary>
    /// <param name="stackWithOpenedBracket"></param>
    /// <returns></returns>
    public bool СompareSymbols(Stack<char> stackWithOpenedBracket)
    {
      return (dictionaryOfBackets.TryGetValue(stackWithOpenedBracket.Peek(), out char closedSymbol));
    }
  }
}