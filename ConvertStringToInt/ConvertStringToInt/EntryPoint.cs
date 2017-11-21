using System;

namespace ConvertStringToInt
{
  /// <summary>
  /// Entry point of application.
  /// </summary>
  class EntryPoint
  {
    const string ENTERSTRING = "Enter your sting for converting to int.\n >> ";
    /// <summary>
    /// Execution the applicaton.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        Console.Write(ENTERSTRING);
        string stringForConvert = Console.ReadLine();
        ConvertorToInt convertor = new ConvertorToInt(stringForConvert);
        convertor.PrintResultNumbers(convertor.CheckAndTransformToInt(convertor.GetListOfDecimal(convertor.GetValideNumbersInString())));
      }
      catch(Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
