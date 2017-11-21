using System;

namespace Task_1
{
  /// <summary>
  /// This class converts string to int if it can.
  /// </summary>
  class StringToIntConverter
  {
    private const char FirstIntNumber = '0';
    private const char LastIntNumber = '9';
    private const char Minus = '-';

    private int ConvertSymbolToInt(char symbol)
    {
      return symbol - FirstIntNumber;
    }

    /// <summary>
    /// Converts string to int if it can.
    /// </summary>
    /// <param name="text">String, which need to convert to int.</param>
    /// <returns>Converted string.</returns>
    public int ConvertStringToInt(string text)
    {
      if (text.Length == 0)
      {
        throw new ArgumentException();
      }

      int firstSymbolIsMinus = 0;
      if (text[0] == Minus && text.Length == 1)
      {
        throw new ArgumentException();
      }
      else if (text[0] == Minus && text.Length > 1)
      {
        firstSymbolIsMinus++;
      }

      int resultNumber = 0;
      for (int i = firstSymbolIsMinus; i < text.Length; i++)
      {
        if (text[i] < FirstIntNumber || text[i] > LastIntNumber)
        {
          throw new ArgumentException();
        }
        else
        {
          resultNumber = (resultNumber * 10 + ConvertSymbolToInt(text[i]));
        }
      }
      if(firstSymbolIsMinus == 1)
      {
        resultNumber = 0 - resultNumber;
      }
      return resultNumber;
    }
  }
}
