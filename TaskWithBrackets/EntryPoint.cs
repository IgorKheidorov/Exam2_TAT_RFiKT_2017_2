using System;

namespace BracketsOfDifferentTypes
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input string");
      string inputString = Console.ReadLine();
      Brackets brackets = new Brackets();
      brackets.CheckInputStringForBrackets(inputString);
    }
  }
}
