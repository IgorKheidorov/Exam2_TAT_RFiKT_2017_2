using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace XMLToDOM
{
  class SearcherTags
  {
    private static readonly string PATH = @"...your path...";
    private string stringFromXML; 

    /// <summary>
    /// For reading from txt file.
    /// </summary>
    /// <returns></returns>
    public string GetStringFromTXT()
    {
      using (StreamReader reader = new StreamReader(PATH, Encoding.Default))
      {
        stringFromXML = reader.ReadToEnd();
      }
      return stringFromXML;
    }

    /// <summary>
    /// For searching tags in string by using Regex class.
    /// </summary>
    /// <param name="stringFromXML"></param>
    public List<string> GetTegs(string stringFromXML)
    {
      Regex reg = new Regex(@"<[^>]+>");
      MatchCollection tags = reg.Matches(stringFromXML);
      List<string> arrayOfTags = new List<string>();
      foreach (var element in tags)
      {
        arrayOfTags.Add(element.ToString());
      }
      return arrayOfTags;
    }

    /// <summary>
    /// Cut all heirs between root start tag and to end tag. Then get heirs.
    /// </summary>
    /// <param name="tags"></param>
    public string CutHeirs(List<string> tags)
    {
      string partOfHeirs = null;
      for (int i = 0; i < tags.Count; i++)
      {
        int indexOfStart = stringFromXML.IndexOf(tags[i].ToString());
        int indexOfEnd = stringFromXML.IndexOf(tags[i][0].ToString() + '\\');
        partOfHeirs = stringFromXML.Substring(indexOfStart, indexOfEnd);
      }
      return partOfHeirs;
      //TODO:Cut all fields from indexOfStart to indexOfEnd. Do it by using recursion. And add it to List.
    }
  }
}