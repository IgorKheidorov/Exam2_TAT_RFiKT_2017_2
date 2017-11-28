using System;

namespace ComplexNumbers
{
  /// <summary>
  /// The point where program starts.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      ComplexNumber number1 = new ComplexNumber(5, 10);
      ComplexNumber number2 = new ComplexNumber(15, 20);
      ComplexNumber result = number1*number2;
      Console.Write(result);
    }
  }
}
