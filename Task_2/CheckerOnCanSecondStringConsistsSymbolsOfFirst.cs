using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSecondStringConsistsFromFirstString
{
  public class CheckerOnCanSecondStringConsistsSymbolsOfFirst
  {
    String firstString;
    String secondString;

    public CheckerOnCanSecondStringConsistsSymbolsOfFirst(String firstString, String secondString)
    {
      this.firstString = firstString;
      this.secondString = secondString;
    }

    public Boolean CheckOnSecondStringHasAllSymbolsOfFirst()
    {
      int counter = 0;
      for(int i = 0; i <= secondString.Length; i++)
      {
        if (firstString.Contains(secondString[i]))
        {
          counter = counter + 1;
        }
      }
      if (counter == secondString.Length)
      {
        return true;
      }
      return false;
    }
  }
}
