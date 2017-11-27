using System;

namespace Test_3.Task_2
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        BracketsValidator validator = new BracketsValidator();
        validator.CheckBracketsAlignment("}");
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      
    }
  }
}
