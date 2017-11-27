using System;

namespace AlgebraicExpression
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Expression expression = new Expression(Console.ReadLine());
        BracketsChecker bracketsChecker = new BracketsChecker(expression.GetBrackets());
        Console.WriteLine(bracketsChecker.CheckBrackets());
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}