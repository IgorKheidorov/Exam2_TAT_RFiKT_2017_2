using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XMLDocumentParserToADOM
{
  class StringContainsManipulator
  {
    Regex regex;
    /// <summary>
    /// This method gets the root opening tag
    /// </summary>
    /// <param name="contentsOfXMLFile"></param>
    /// <returns></returns>
    public string GetRootTag(string contentsOfXMLFile)
    {
      regex = new Regex(@"<[a-z0-9]+>");
      MatchCollection m = regex.Matches(contentsOfXMLFile);
      return m[0].ToString();
    }

    /// <summary>
    /// This method gets the root closing tag
    /// </summary>
    /// <param name="contentsOfXMLFile"></param>
    /// <returns></returns>
    public string GetClosingTag(string contentsOfXMLFile)
    {
      regex = new Regex(@"</[a-z0-9]+>$");
      string closingTag = regex.Match(contentsOfXMLFile).ToString();
      return closingTag;
    }

    ///This method gives everything that is between the root tag and closes the root tag
    ///
    public string GetChildTags(string fileContains, string rootTag, string closingTag)
    {
      fileContains.Substring();
    }
  }
}