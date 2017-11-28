using System;

namespace Test_3.Task_3
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        ComplexNumber result = new ComplexNumber().FoldComplexNumbers(new ComplexNumber(0.5, 1.1), new ComplexNumber(0.5, 0.9));
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
