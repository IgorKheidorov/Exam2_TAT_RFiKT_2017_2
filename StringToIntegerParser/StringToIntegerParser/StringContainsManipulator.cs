using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToIntegerParser
{
  class StringContainsManipulator
  {
    const char ZERO = '0';
    const char NINE = '9';
    const string MINUS = "-";

    /// <summary>
    /// This method checks whether all parts of the string are numbers  
    /// </summary>
    /// <param name="line"></param>
    /// <returns></returns>
    public bool IntChecker(string line)
    {
      bool checker = true;
      for (int i = 0; i < line.Length; i++)
      {
        if (line[i] < ZERO || line[i] > NINE)
        {
          return false;
        }
      }
      return checker;
    }

    private bool CheckForNegativity(string line)
    {
      return line.StartsWith(MINUS);
    }
    private static int CharToInt(char c)
    {
      return c - ZERO;
    }

    /// <summary>
    /// This method parse string to int
    /// </summary>
    /// <returns></returns>
    public int StringParserToInt(string line)
    {
      int finiteNumber = 0;
      for (int i = 0, j = 1; i < line.Length; i++, j++)
      {
        finiteNumber += CharToInt(line[i]) * (int)Math.Pow(10, line.Length - j);
        if (CheckForNegativity(line))
        {
          finiteNumber=finiteNumber * (-1);
        }
        if (finiteNumber > int.MaxValue || finiteNumber < int.MinValue)
        {
          throw new StackOverflowException();
        }
      }
      return finiteNumber;
    }
  }
}
