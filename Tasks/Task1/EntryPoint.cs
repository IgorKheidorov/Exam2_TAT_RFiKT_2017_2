using System;

namespace Task1
{
  /// <summary>
  /// Main method of class
  /// calls instance of class StringConverter
  /// to convert input string to integer
  /// </summary>
  public class EntryPoint
  {
    /// <summary>
    /// Method calls method ConvertToInt of class StringConverter
    /// for getting integer value from inputed from console string
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        int value = new StringConverter().ConvertToInt(Console.ReadLine());
        Console.WriteLine(value);
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
