using System;

namespace ConvertStringToInt
{   
  /// <summary>
  /// For checking the string.
  /// </summary>
  class WrongStringException : Exception
  {
    public override string Message
    {
      get
      {
        return "Wrong string: the string can't be null.";
      }
    }
  }
}

