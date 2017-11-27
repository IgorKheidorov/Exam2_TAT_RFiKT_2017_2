using System;


namespace Brackets
{
  class Program
  {
    /// <summary>
    /// The point where program starts.
    /// </summary>
    static void Main()
    {
      string expression = "{}}";
      BracketsValidator validator = new BracketsValidator(expression);
      Console.Write(validator.ValidateExpression());
    }
  }
}
