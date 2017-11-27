using System.Collections.Generic;

namespace Task
{
  /// <summary>
  /// Class contains dictionary with possible brackets
  /// </summary>
  public class EntryPoint
  {
    public Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>()
    {
      {'}','{' },
      {']','[' },
      {')','(' }
    };
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

    }
  }
}
