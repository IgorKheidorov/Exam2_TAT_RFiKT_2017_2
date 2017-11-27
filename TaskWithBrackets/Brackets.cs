using System;
using System.Collections.Generic;

namespace BracketsOfDifferentTypes
{
  class Brackets
  {
    Stack<char> bracketStack = new Stack<char>();

    public void CheckInputStringForBrackets(string inputString)
    {     
      int round = 0;
      int figured = 0;
      int squared = 0;          
      for (int i = 0; i < inputString.Length; i++)
      {
        if (inputString[i] == '(') round++;
        else if (inputString[i] == ')') round--;
        else if (inputString[i] == '{') figured++;
        else if (inputString[i] == '}') figured--;
        else if (inputString[i] == '[') squared++;
        else if (inputString[i] == ']') squared--;

        CheckExcessBracket(round, figured, squared);
        AddToStack(inputString);




      }
    }

    /// <summary>
    /// Checks if the closing bracket is on the corresponding opening.
    /// </summary>
    /// <param name="round">number round brackets</param>
    /// <param name="figured">number figured brackets</param>
    /// <param name="squared">number squared brackets</param>
    public void CheckExcessBracket(int round, int figured, int squared)
    {
      if (round < 0 || figured < 0 || squared < 0)
      {        
        Console.WriteLine("Excess closing bracket");        
      }
    }

    /// <summary>
    /// Adds the opening brackets to the stack.
    /// </summary>
    /// <param name="inputString">yout input string</param>
    /// <returns>stack with brackets</returns>
    public Stack<char> AddToStack(string inputString)
    {
      for (int i = 0; i < inputString.Length; i++)
      {
        if ((inputString[i] == '(') || (inputString[i] == '{') || (inputString[i] == '['))
        {                   
          bracketStack.Push(inputString[i]);         
        }
      }
      return bracketStack;
    }
  }
}
