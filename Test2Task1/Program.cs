using System;


namespace Test2Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        string line = Console.ReadLine();
        IntegerParser parser = new IntegerParser(line);
        Console.Write(parser.ConvertToInt());
      }
      catch (Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
