using System;

namespace IntParser
{
  class NotIntegerException : Exception
  {
    const string NOTANINTEGER = "This is not a number.";

    public NotIntegerException(string message = NOTANINTEGER) : base(message) { }
  }
}