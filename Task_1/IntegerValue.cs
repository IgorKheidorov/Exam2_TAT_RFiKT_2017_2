using System;

namespace Task_1
{
  class IntegerValue
  {
    private char FIRST_VALUE = '0';
    private char LAST_VALUE = '9';

    private bool IsInt(string value)
    {
      char[] charValue = value.ToCharArray();
      for (int i = 0; i < charValue.Length; i++)
      {
        if (i > 0 && charValue[i] == '.')
        {
          return true;
        }
      }
      return false;
    }

    public int ConvertsFromStringToInt(string value)
    {
      int convertValue = 0;
      char[] charArray = value.ToCharArray();

      for (int i = 0; i < charArray.Length; i++)
      {
        if (charArray[i] > FIRST_VALUE && charArray[i] <= LAST_VALUE)
        {
          convertValue = ((int)char.GetNumericValue(charArray[i]) * (int)Math.Pow(10, charArray.Length - 1));
        }
        else
        {
          break;
        }
      }
      return convertValue;
    }
  }
}
