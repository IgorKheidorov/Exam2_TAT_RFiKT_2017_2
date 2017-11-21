using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertStringToInt
{ 
  /// <summary>
  /// Class is used to convert any valid string to Int number.
  /// </summary>
  public class ConvertorToInt
  {
    const int INT32MAX = 2147483647;

    private string stringForConvert;

    //There are checking for not empty or null string.
    public string StringForConvert
    {
      get
      {
        return stringForConvert;
      }
      set
      {
        stringForConvert = value;
        if (stringForConvert == String.Empty && stringForConvert != null)
        {
          throw new WrongStringException();
        }
      }
    }

    public ConvertorToInt(string stringFromConsole)
    {
      StringForConvert = stringFromConsole;
    }

    /// <summary>
    /// Get list of numbers from string.
    /// </summary>
    /// <returns></returns>
    public List<string> GetValideNumbersInString()
    {
      List<string> arrayOfValidValues = new List<string>();
      string[] partsOfString = StringForConvert.Split(' ');

      for (int i = 0; i < partsOfString.Length; i++)
      {
        for (int j = 0; j < partsOfString.Length; j++)
        {
          int bufferCounter = 0;
          if (!(partsOfString[i][j] >= '0' && partsOfString[i][j] <= '9'))
          {
            break;
          }
          else if (partsOfString[i][j] >= '0' && partsOfString[i][j] <= '9')
          {
            bufferCounter++;
          }
          if (bufferCounter == partsOfString[i].Length)
          {
            arrayOfValidValues.Add(partsOfString[i]);
          }
        }       
      }
      return arrayOfValidValues;
    }

    /// <summary>
    /// Get list of decimal that uses for checking to int.
    /// </summary>
    /// <param name="arrayOfValidValues"></param>
    /// <returns></returns>
    public List<Decimal> GetListOfDecimal(List<string> arrayOfValidValues)
    {
      List<Decimal> list= new List<Decimal>();
      for(int i =0; i < arrayOfValidValues.Count; i++ )
      {
        list.Add(Convert.ToDecimal(arrayOfValidValues[i]));
      }
      return list;
    }

    /// <summary>
    /// Check if number less than max value of int32.
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public List<int> CheckAndTransformToInt(List<Decimal> list)
    {
      List <int> resultList = new List<int>();
      for(int i = 0; i < list.Count; i++)
      {
        if(list[i] <= INT32MAX)
        {
          resultList.Add(Convert.ToInt32(list[i]));
        }
      }
      return resultList;
    }

    /// <summary>
    /// Use for print result numbers.
    /// </summary>
    /// <param name="resultList"></param>
    public void PrintResultNumbers(List<int> resultList)
    {
      StringBuilder builder = new StringBuilder();
      foreach(var element in resultList)
      {
        builder.Append(element + " ");
      }
    }
  }
}
