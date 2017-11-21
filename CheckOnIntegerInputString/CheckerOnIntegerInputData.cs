using System;
using System.Text;

namespace CheckOnIntegerInputString
{
  /*
   * This program check input string on is it integer value and return int.
   */
  public class CheckerOnIntegerInputData
  {
    String inputString;
    private int FIRSTNUMBEROFNUMBERSASCII = 48;
    private int FINALNUMBEROFNUMBERSASCII = 57;

    public CheckerOnIntegerInputData(String inputString)
    {
      this.inputString = inputString;
    }
    /*
     * This method check input string on integer values of each symbol of this string.
     * 
     * @params String inputString
     * @return true (if all symbols of string is integer numbers) false (vice versa)
     */
    public Boolean CheckOnIntegerInputData()
    {
      byte[] numberOfSymbolInASII;
      numberOfSymbolInASII = Encoding.Default.GetBytes(inputString);
      int counter = 0;
      for (int i = 0; i < inputString.Length; i++)
      {
        if (numberOfSymbolInASII[i] > FIRSTNUMBEROFNUMBERSASCII && numberOfSymbolInASII[i] < FINALNUMBEROFNUMBERSASCII)
         {
           counter = counter + 1;
         }
      }
      if (counter == inputString.Length)
      {
        return true;
      }
      return false;
    }

    /*
     * This method check create and return int value all symbols of string is integer numbers.
     *
     * @params String inputString
     * @return int integerValueOfString
     */
    public Int64 CreateIntIfStringIsInt()
    {
      Int64 integerValue = Convert.ToInt64(inputString);
      return integerValue;
      /*
      int integerValue = 0;
      if (CheckOnIntegerInputData(inputString))
      {
        for (int i = 0; i < inputString.Length; i++)
        {

          integerValue = integerValue + inputString[i] * (int)Math.Pow(10, i);
        }
      }
      return integerValue;
      */
    }
  }
}
