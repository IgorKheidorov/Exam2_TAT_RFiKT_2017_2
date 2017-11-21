using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Task1
{
 public class IntegerParser
  {
    string lineForParse;
    int[] numbers;
    bool isNegative=false;
    public IntegerParser(string line)
    {
      lineForParse = line;
    }
    private bool CheckString()
    {
      if (lineForParse[0] == '-')
      {
        isNegative = true;
      }
      if (lineForParse.Length > 10 || (lineForParse.Length==10 && lineForParse[0]>'2'))
      {
        return false;
      }
      if (lineForParse[0] == '-' ||(lineForParse[0] > '0' && lineForParse[0] <= '9'))
      {
        for (int i = 1; i < lineForParse.Length; i++)
        {
          if (lineForParse[i] < '0' || lineForParse[i] > '9')
          {
            return false;
          }
        }
      }
      else
      {
        return false;
      }
      return true;
    }
    private void MakeANumbersArray()
    {
      if (!isNegative)
      {
        numbers = new int[lineForParse.Length];
        for (int i = 0; i < lineForParse.Length; i++)
        {
          numbers[i] = (int)lineForParse[i] - 48; // 48 - is code for symbol '0'
        }
      }
      else
      {
        numbers = new int[lineForParse.Length-1];
        for (int i = 0; i < lineForParse.Length-1; i++)
        {
          numbers[i] = (int)lineForParse[i+1] - 48; // 48 - is code for symbol '0'
        }
      }
    }
    private int CalculateResult()
    {
      int result = 0;
      int currentSum = 0;
      for (int i = numbers.Length; i >= 1; i--)
      {
        currentSum=(int)Math.Pow(10, numbers.Length - i) * (int)numbers[i-1];
        if(currentSum+result<0)
        {
          throw new Exception("Your number is out of Integer range!");
        }
        result += currentSum;
      }
      if (result > Int32.MaxValue || result < Int32.MinValue)
      {
        throw new Exception("Your number is out of Integer range!");
      }
      return result;
    }
    public int ConvertToInt()
    {
      if (!CheckString())
      {
        throw new Exception("The string you input is not an integer number!");
      }
      else
      {
        MakeANumbersArray();
      }
      int result = CalculateResult();
      return (isNegative ? -result : result);
    }

  }
}
