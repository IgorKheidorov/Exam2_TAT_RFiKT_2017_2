using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
      string value = Console.ReadLine();
      IntegerValue integerValue = new IntegerValue();
      Console.WriteLine(integerValue.ConvertsFromStringToInt(value));
    }
  }
}
