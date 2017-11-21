using System;

namespace Task1
{
  /// <summary>
  /// Check if input string can present an integer value. If it can - convert to Integer.
  /// String is inputed from the console.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string value = "21421";
      var converter = new StringToIntConverter(value);
      int result = 0;
      try
      {
        if (converter.CanConvertToInt())
        {
          result = converter.ConvertToInt();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      Console.WriteLine(result);
    }
  }
}
