using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DOM
{
  public class XMLReader
  {
    public string XMLFileContent { get; set; }
    Regex regex;
    public string FilePath { get; set; }

    /// <summary>
    /// This is constructor for XMLReader class.
    /// </summary>
    /// <param name="filePath"> path to the file </param>
    public XMLReader(string filePath)
    {
      FilePath = filePath;
    }

    /// <summary>
    /// This method reads all xml file.
    /// </summary>
    /// <returns> xml file contents </returns>
    public string ReadXML()
    {
      XMLFileContent = string.Empty;
      using (StreamReader streamReader = new StreamReader(FilePath, Encoding.Default))
      {
        XMLFileContent = streamReader.ReadToEnd();
      }
      return XMLFileContent;
    }

    /// <summary>
    /// This method gets root name.
    /// </summary>
    /// <returns> root name </returns>
    public string GetRootTag(string XMLFileContent)
    {
      regex = new Regex(@"<[a-z0-9]+>");
      MatchCollection tags = regex.Matches(XMLFileContent);
      return tags[0].ToString();
    }

    /// <summary>
    /// This method gets closed root name.
    /// </summary>
    /// <returns> root name </returns>
    public string GetClosedRootTag(string XMLFileContent)
    {
      regex = new Regex(@"</[a-z0-9]+>$");
      return regex.Match(XMLFileContent).ToString();
    }

    /* /// <summary>
     /// This method gets content in root.
     /// </summary>
     public void GetContentsInRoot()
     {
       //string contents = XMLFileContent.Substring(XMLFileContent.IndexOf(GetRootTag()),XMLFileContent.IndexOf('\\' + GetRootTag()));
       regex = new Regex(@"<[a-z0-9]+>[a-z0-9<>/]+</[a-z0-9]+>$");
       string tags = regex.Match(XMLFileContent).ToString();
       Console.WriteLine(tags);
     }*/

    /// <summary>
    /// This method gets content in root.
    /// </summary>
    public string GetContentInRoot()
    {
      int startOfTheRoot = XMLFileContent.IndexOf(GetRootTag(XMLFileContent));
      int endOfTheRoot = XMLFileContent.IndexOf(GetClosedRootTag(XMLFileContent));
     return XMLFileContent.Substring(startOfTheRoot, endOfTheRoot - startOfTheRoot);
    }
  }
}