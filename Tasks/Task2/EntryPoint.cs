using System;
using System.Linq;

namespace Task2
{
  public class EntryPoint
  {
    private const string Inpossible = "Inpossible";
    static void Main(string[] args)
    {
      string line1 = "abcdef";
      string line2 = "fbcdef";

      foreach (var item1 in line1)
      {
        if (line2.Contains(item1))
        {
          line2 = line2.Remove(line2.IndexOf(item1), 0);
        }
        else
        {
          Console.WriteLine(Inpossible);
        }
      }
    }
  }
}
