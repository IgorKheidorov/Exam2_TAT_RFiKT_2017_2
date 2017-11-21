using System;

namespace Task1
{
  /// <summary>
  /// Class contains method
  /// to convert string to int
  /// and help methods to check
  /// if this converting valid
  /// </summary>
  public class StringConverter
  {
    private const string CannotConvert = "Cannot convert";
    private const string Minus = "-";
    private const int AsciiNullIndex = 48;
    private const int AsciiNineIndex = 57;
    private const int Ten = 10;

    /// <summary>
    /// Methos converts string to int
    /// or throws exception if it is inpossible
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public int ConvertToInt(string input)
    {
      int value = 0;
      string convertedToIntString = input;
      bool isNegative = false;

      if (IsStartWithMinus(input))
      {
        convertedToIntString = convertedToIntString.Remove(0, 1);
        isNegative = true;
      }

      foreach (var item in convertedToIntString)
      {
        char symbol = item;
        if (IsSymbolNumber(symbol))
        {
          if (IsTranslationDigitThrowsOverflow(value)
            || IsIntSumThrowsOverflow(TranslationDigit(value), symbol - AsciiNullIndex))
          {
            throw new OverflowException();
          }
          value = TranslationDigit(value) + (symbol - AsciiNullIndex);
        }
        else
        {
          throw new ArgumentException(CannotConvert);
        }
      }

      if (isNegative)
      {
        value = value * (-1);
      }
      return value;
    }

    private int TranslationDigit(int value)
    {
      return Ten * value;
    }

    /// <summary>
    /// Check on possible negative number
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public bool IsStartWithMinus(string input)
    {
      return input.StartsWith(Minus);
    }

    /// <summary>
    /// Check if symbol in string is number
    /// </summary>
    /// <param name="symbol"></param>
    /// <returns></returns>
    public bool IsSymbolNumber(char symbol)
    {
      return (symbol >= AsciiNullIndex && symbol <= AsciiNineIndex);
    }

    /// <summary>
    /// Check sum of numbers on overflow
    /// </summary>
    /// <param name="value">First term</param>
    /// <param name="term">Second term</param>
    /// <returns></returns>
    public bool IsIntSumThrowsOverflow(int value, int term)
    {
      return int.MinValue + term > value || value > int.MaxValue - term;
    }

    /// <summary>
    /// Check translation digit of numbers on overflow
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool IsTranslationDigitThrowsOverflow(int value)
    {
      return int.MinValue + value > value || value > int.MaxValue - value;
    }
  }
}
