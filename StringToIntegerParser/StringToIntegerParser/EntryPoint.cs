using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToIntegerParser
{
  class EntryPoint
  {
    static void Main()
    {
      Console.WriteLine("Enter string");
      string enteredString = Console.ReadLine();
      StringContainsManipulator stringContainsManipulator = new StringContainsManipulator();
      bool Check = stringContainsManipulator.IntChecker(enteredString);
      if (Check == true)
      {
        Console.WriteLine("Number =" + stringContainsManipulator.StringParserToInt(enteredString));
      }
      else
      {
        Console.WriteLine("This string can not be converted");
      }
      Console.ReadKey();
    }
  }
}
