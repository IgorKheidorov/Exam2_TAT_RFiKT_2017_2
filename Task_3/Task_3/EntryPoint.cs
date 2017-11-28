using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        ComplexNumber firstNumber = new ComplexNumber(4.5, 3.0);
        ComplexNumber secondNumber = new ComplexNumber(1.1, 0.5);
        ComplexNumber complexNumber = new ComplexNumber();
        complexNumber.SumComplexNumber(firstNumber, secondNumber).SubtractComplexNumber(firstNumber, secondNumber).MultiplicationComplexNumber(firstNumber, secondNumber);
      }
      catch (ArgumentException e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
