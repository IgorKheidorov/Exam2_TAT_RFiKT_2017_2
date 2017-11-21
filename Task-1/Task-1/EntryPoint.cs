using System;

namespace Task_1
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Enter string: ");
        StringToIntConverter converter = new StringToIntConverter();
        Console.WriteLine(converter.ConvertStringToInt(Console.ReadLine()));
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
