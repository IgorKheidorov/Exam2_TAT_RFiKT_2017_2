using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XMLDocumentParserToADOM
{
  /// <summary>
  /// This class contains of metod which reads the contents of a file
  /// </summary>
  class ReaderFromXMLFile
  {
    public string FilePath { get; set; }

    /// <summary>
    /// This method returns the contents of a file
    /// </summary>
    /// <param name="filePath">the path to the file</param>
    public ReaderFromXMLFile(string filePath)
    {
      FilePath = filePath;
    }
    public string ReadFromFile()
    {
      string contentsOfXMLFile;
      using (StreamReader streamReader = new StreamReader(FilePath, Encoding.Default))
      {
        contentsOfXMLFile = streamReader.ReadToEnd();
      }
      return contentsOfXMLFile;
    }
  }
}