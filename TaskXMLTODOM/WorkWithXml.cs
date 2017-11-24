using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace XmlToDom
{
  
  public class WorkWithXml
  {
    String allXml;

    public String getAllXml()
    {
      return allXml;
    }

    /*
     * This method read data from txt file by path.
     */
    public void ReadXmlFile()
    {
      StringBuilder stringBuilder = new StringBuilder();
      String path = @"D:\MyData\Programming\CSharp\univerAuditornie\testAfterTests\XmlToDom\XmlToDom\Cars.xml";
      allXml = "";
      using (StreamReader stream = new StreamReader(path, System.Text.Encoding.Default))
      {
        //line = stream.ReadToEnd();
        while (!stream.EndOfStream)
        {
          allXml = stream.ReadLine();
          stringBuilder.Append(allXml);
        }
      }
      allXml = stringBuilder.ToString();
    }

    /*
     * Method find all substrings in all xml string in figure brekets
     */
    public String[] FindTag()
    {
      Regex regex = new Regex(@"<[^>]+>");
      MatchCollection matches = regex.Matches(allXml);
      String[] allXmlSeparated = new String[matches.Count];
      for (int i = 0; i < matches.Count; i++)
      {
        for (int j = 1; j < matches.Count; j++)
        {
          allXmlSeparated[i] = matches[j].ToString();
          i = j;
        }
      }
      return allXmlSeparated;
    }

    /*
     * This method return string without brackets
     */
    public String ReturnStringInBrackets(String tagString)
    {
      if (tagString.Contains('/'))
      {
        return tagString.Substring(2, tagString.Length - 3);
      }
      return tagString.Substring(1, tagString.Length - 2);
    }

    /*
     * This method check that string has "/"
     */
    public Boolean StringHasSlash(String chekingString)
    {
      if (chekingString.Contains('/'))
      {
        return true;
      }
      return false;
    }

    /*
     * This method return list with tags 
     */
    public List<String> CreateListWithTags(String[] allXmlSeparated)
    {
      var tags = new List<String>();
      for(int j = 1; j < allXmlSeparated.Length; j++)
      {
        tags.Add(allXmlSeparated[j]);
      }
      return tags;
    }

    /*
     * This method count number of inserted tags
     */
    public int CountOfInsertTags(List<String> listOfTags)
    {
      List<String> tags = listOfTags;
      while (ReturnStringInBrackets(tags[tags.Count - 1]).Equals(ReturnStringInBrackets(tags[0])) && tags[tags.Count - 1].Contains('/'))
      {
        tags.RemoveAt(0);
        tags.RemoveAt(tags.Count - 1);
      }
      return tags.Count / 2;
    }

    /*
     * This method Create structure of tags
     * There i will create struck use methode befor, sorry i haven't time to do all correctly
     */
   /* public List<ElementXml> CreateStrucktOfTags(List<String> tags)
    {
      int countOfTags = tags.Count / 2;
      var elements = new List<ElementXml>();
      
      return elements;
    }*/
  }
}
