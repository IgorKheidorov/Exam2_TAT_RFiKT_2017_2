using System;

namespace TaskAboutBrackets
{
  /// <summary>
  /// Entry point.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      StringValidator validator = new StringValidator();
      Console.WriteLine("Enter an expression :");
      Console.WriteLine(validator.StringIsValid(Console.ReadLine()));
    }
  }
}
