using System;
using System.Text;

namespace Task1
{
  /// <summary>
  /// Performs converting from string to int if its possible.
  /// </summary>
  public class StringToIntConverter
  {
    public string StringValue { get; private set; }
    public bool ContainsDotOrComma { get; private set; }
    public bool ContainsExpSymbol { get; private set; }

    /// <summary>
    /// Initialize converter with converted string.
    /// </summary>
    /// <param name="stringValue"></param>
    public StringToIntConverter(string stringValue)
    {
      StringValue = stringValue;
      ContainsDotOrComma = false;
      ContainsExpSymbol = false;
    }

    /// <summary>
    /// Convert defined string to int.
    /// If it's not possible throw FormatException.
    /// Returns int.
    /// </summary>
    /// <returns></returns>
    public int ConvertToInt()
    {
      int intValue;
      if (!CanConvertToInt())
      {
        throw new FormatException();
      }

      if (ContainsDotOrComma)
      {
        int indexOfDotOrComma = StringValue.IndexOfAny(new char[] { '.', ',' });
        intValue = ConvertStringPartToInt(0, indexOfDotOrComma);
      }
      else if (ContainsExpSymbol)
      {
        int indexOfExp = StringValue.IndexOfAny(new char[] { '^', 'e' });
        intValue = ConvertStringPartToInt(0, indexOfExp);
      }
      else
      {
        intValue = ConvertStringPartToInt(0, StringValue.Length);
      }

      return intValue;
    }

    /// <summary>
    /// Performs converting a part of defined string mathematically.
    /// </summary>
    /// <param name="beginIndex">String start position.</param>
    /// <param name="endIndex">String end position.</param>
    /// <returns></returns>
    private int ConvertStringPartToInt(int beginIndex, int endIndex)
    {
      int value = 0;
      int bitNumber = 10;
      int bitPower = 0;
      for (int i = StringValue.Substring(beginIndex, endIndex).Length - 1; i >=0 ; i--)
      {
        value += (int)StringValue[i] * (int)Math.Pow(bitNumber, bitPower);
        bitPower++;
      }
      return value;
    }

    /// <summary>
    /// Checks if its possible to convert defined string to int.
    /// Returns true if it's possible.
    /// </summary>
    /// <returns></returns>
    public bool CanConvertToInt()
    {
      char[] stringConstituents = StringValue.ToCharArray();

      for(int i = 0; i < stringConstituents.Length; i++)
      {
        //
        if ((int)stringConstituents[i] < AssemblyInfo.UTF8_ZERO_CODE || (int)stringConstituents[i] > AssemblyInfo.UTF8_NINE_CODE)
        {
          if (!CheckCharForAppropriateDotsAndCommas(i) || !CheckCharForValidExponentalForm(i))
          {
            return false;
          }
        }       
      }
      return true;
    }

    /// <summary>
    /// Check if defined string contains an appropriate dot or comma separators for converting string to int.
    /// Returns true if string contains an appropriate dot or comma separators or do not contain any of them at all.
    /// </summary>
    /// <param name="charIndex"></param>
    /// <returns></returns>
    private bool CheckCharForAppropriateDotsAndCommas(int charIndex)
    {
      if ((StringValue[charIndex] == '.' || StringValue[charIndex] == ',') && StringValue.Length != charIndex + 1)
      {
        ContainsDotOrComma = true;
        for (int i = charIndex; i < StringValue.Length; i++)
        {
          if (StringValue[i] != AssemblyInfo.UTF8_ZERO_CODE)
          {
            return false;
          }
        }
      }

      return true;
    }
    /// <summary>
    /// Check if defined string contains an appropriate exponential separators for converting string to int.
    /// Returns true if string contains an appropriate exponential separators or do not contain any of them at all.
    /// </summary>
    /// <param name="charIndex"></param>
    /// <returns></returns>
    private bool CheckCharForValidExponentalForm(int charIndex)
    {
      if (StringValue[charIndex] == '^' || StringValue[charIndex] == 'e')
      {
        ContainsExpSymbol = true;
        for (int i = charIndex; i < StringValue.Length; i++)
        {
          if ((int)StringValue[i] < AssemblyInfo.UTF8_ZERO_CODE || (int)StringValue[i] > AssemblyInfo.UTF8_NINE_CODE)
          {
            return false;
          }
        }
      }

      return true;
    }
  }
}
