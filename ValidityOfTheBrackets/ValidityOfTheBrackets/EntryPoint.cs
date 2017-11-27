using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidityOfTheBrackets
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Enter algebraic expression: ");
        string algebraicEpression = Console.ReadLine();
        ExpressionValidator expressionValidator = new ExpressionValidator();
        if (expressionValidator.IsStringEmpty(algebraicEpression))
        {
          Console.WriteLine("The expression is valid");
        }
        else
        {
          string ListOfBrackets = expressionValidator.DetermineBrackets(algebraicEpression);
          bool BracketsAreValid = expressionValidator.DetermineTheValidityOfTheBrackets(ListOfBrackets);
          if (BracketsAreValid == true)
          {
            Console.WriteLine("The expression is valid");
          }
          else
          {
            Console.WriteLine("The expression isn't valid");
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}