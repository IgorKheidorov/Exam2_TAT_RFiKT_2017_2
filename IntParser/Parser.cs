using System;

namespace IntParser
{
  /// <summary>
  /// This is class to parse string to int.
  /// </summary>
  class Parser
  {
    public static readonly char ZERO = '0';
    public static readonly char NINE = '9';
    public static readonly string MINUS = "-";

    public string StringNumber { get; set; }

    /// <summary>
    /// This is constructor for parser class.
    /// </summary>
    /// <param name="inputtedString"> inputted string </param>
    public Parser(string inputtedString)
    {
      StringNumber = inputtedString;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="StringNumber"> inputted string </param>
    /// <returns></returns>
    public bool CheckIfNull(string StringNumber)
    {
      if (StringNumber.Length == 0)
      {
        throw new NotIntegerException();
      }
      return true;
    }

    /// <summary>
    /// This method convert element from inputted string to int.
    /// </summary>
    /// <param name="element"> number from inputted value </param>
    /// <returns> parced to int value </returns>
    private int CharToInt(char element)
    {
      return element - ZERO;
    }

    /// <summary>
    /// This method checks if inputted value is negative.
    /// </summary>
    /// <param name="StringNumber"> inputted value </param>
    /// <returns> true if it is starts with minus </returns>
    public bool IsNegative(string StringNumber)
    {
      return StringNumber.StartsWith(MINUS);
    }

    /// <summary>
    /// This method cheks if number is integer.
    /// </summary>
    /// <param name="number"> number from inputted string </param>
    /// <returns> true if it is ineger </returns>
    public bool IsInteger(char number)
    {
      return (number > ZERO && number < NINE);
    }

    /// <summary>
    /// This method parse string to int.
    /// </summary>
    /// <returns> int value </returns>
    public int ParseToInt(string StringNumber)
    {
      int result = 0;
      for (int i = 0; i < StringNumber.Length; i++)
      {
        if (IsInteger(StringNumber[i]))
        {
          result = checked(result * 10 + CharToInt(StringNumber[i]));
          if (IsNegative(StringNumber))
          {
            result += -1;
          }
        }
        else
        {
          throw new NotIntegerException();
        }
      }
      return result;
    }
  }
}