using System;
using System.Collections.Generic;

namespace ValidBrackets
{
  /*
   * This class check algerbraick expression on validity
   */
  public class ValidatorAlgebraicExpression
  {
    Char[] BRACKETS = { '(', ')', '[', ']', '{', '}' };

    /*
     * This methode check expression on validity
     * 
     * @param String expression
     * @return Boolean true (if expression is Valid) false (if expression is'n valid)
     */
    public Boolean CheckExpressionOnValidity(String expression)
    {
      return CheckOnEmptyString(expression) && (CheckOnCountOfBrackets(expression) && CheckOnOpenAndCloseBrackets(expression));
    }

    /*
     * This method check expression on empty.
     * 
     * @param String expression
     * @return True (if expression not empty) false (if string is empty)
     */
    public Boolean CheckOnEmptyString(String expression)
    {
      return !expression.Equals(String.Empty);
    }

    /*
     *This methode check expression on valid count of Brackets.
     * 
     * @param String expression
     * @return Boolean true(if expression is valid) false (if expression is not valid)
     */
    public Boolean CheckOnCountOfBrackets(String expression)
    {
      int[] countBrackets = new int[3];
      for (int i = 0; i < expression.Length; i++)
      {
        if (expression[i].Equals(BRACKETS[0])) countBrackets[0]++;
        if (expression[i].Equals(BRACKETS[1])) countBrackets[0]--;
        if (expression[i].Equals(BRACKETS[2])) countBrackets[1]++;
        if (expression[i].Equals(BRACKETS[3])) countBrackets[1]--;
        if (expression[i].Equals(BRACKETS[4])) countBrackets[2]++;
        if (expression[i].Equals(BRACKETS[5])) countBrackets[2]--;
      }
      return (countBrackets[0] == 0 && countBrackets[1] == 0 && countBrackets[2] == 0);
    }

    /*
     * This method return list With Brackets in expression
     * 
     * @param String expression
     * @return List of Brackets
     */
    public List<Char> CreateListWithBrackets(String expression)
    {
      var brackets = new List<Char>();
      for (int j = 0; j < BRACKETS.Length; j++)
      {
        for (int i = 0; i < expression.Length; i++)
        {
          if (expression[i].Equals(BRACKETS[j]))
          {
            brackets.Add(expression[i]);
          }
        }
      }
      return brackets;
    }

    /*
     * Identify which of bracket in our list
     * 
     * @param Char symbol(bracket
     * @return int number (number of string[] BRACKETS)
     */
    public int identifyBracket(Char bracket)
    {
      for (int i = 0; i <= BRACKETS[i]; i++)
      {
        if (bracket.Equals(BRACKETS[i]))
          return i;
      }
      return 0;
    }
    
    /*
     * This methode find open bracket and close braket, and delete corresponding
     * 
     * @param List<Char> (list of brackets)
     * @return true (if all brackets have couples) false (if just one brackets hasn't couple)
     */
    public Boolean CheckOnCorrespondinOpenAndCloseBrackets(List<Char> brackets)
    {
      for (int i = 0; i < brackets.Count; i++)
      {
        if (identifyBracket(brackets[0]) % 2 == 0)
        {
          if (brackets.Contains(BRACKETS[identifyBracket(brackets[0]) + 1]))
          {
            brackets.Remove(BRACKETS[identifyBracket(brackets[0]) + 1]);
            brackets.Remove(brackets[0]);
            i = 0;
          }
        }
      }
      return (brackets.Count == 0);
    }

    /*
     * This method check on to the existence of an open and corresponding closed
     * 
     * @param String expression
     * @return true (if all brackets have couple)
     */
    public Boolean CheckOnOpenAndCloseBrackets(String expression)
    {
      return CheckOnCorrespondinOpenAndCloseBrackets(CreateListWithBrackets(expression));
    }
  }
}
