using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DOM
{
  class Searcher
  {
    /// <summary>
    /// This method is used to search tags in XML document.
    /// </summary>
    /// <param name="line">Data from xml document</param>
    public List<string> GetTags(string line)
    {
      Regex regex = new Regex(@"<[^>]+>");
      MatchCollection matches = regex.Matches(line);
      List<string> listOftags = new List<string>();
      foreach (var tag in matches)
      {
        listOftags.Add(tag.ToString());
      }
      return listOftags;
    }

    /// <summary>
    /// Find start and end index of tags.
    /// </summary>
    /// <param name="listOftags">Array Of tags</param>
    /// <param name="line">Data from xml document</param>   
    public string FindSuccessor(List<string> listOftags, string line)
    {
      string inheritor = null;
      for (int i = 0; i < listOftags.Count; i++)
      {
        int firstIndex = line.IndexOf(listOftags[i]);
        int endIndex = line.IndexOf(listOftags[i][0].ToString() + '\\');
        inheritor = line.Substring(firstIndex, endIndex);
      }
      return inheritor;
    }
  }
}
