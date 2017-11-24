using System.Linq;

namespace Task2
{
  /// <summary>
  /// 
  /// </summary>
  public class StringsAnalyzer
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="firstString"></param>
    /// <param name="secondString"></param>
    /// <returns></returns>
    public bool IsPossibleCreateFirstStringFromElemsFromSecond(string firstString, string secondString)
    {
      string line1 = firstString;
      string line2 = secondString;
      bool isPossible = false;

      foreach (var item1 in line1)
      {
        if (line2.Contains(item1))
        {
          line2 = line2.Remove(line2.IndexOf(item1), 0);
          isPossible = true;
        }
        else
        {
          isPossible = false;
          break;
        }
      }

      return isPossible;
    }
  }
}
