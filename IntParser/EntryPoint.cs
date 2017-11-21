using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntParser
{
  /// <summary>
  /// EntryPoint to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        string number = Console.ReadLine();
        Parser parser = new Parser(number);
        Console.WriteLine(parser.ParseToInt(number));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}