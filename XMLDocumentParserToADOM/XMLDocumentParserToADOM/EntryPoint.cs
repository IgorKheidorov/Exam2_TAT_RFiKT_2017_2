using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDocumentParserToADOM
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string filePath = args[0];
      ReaderFromXMLFile readerFromXMLFile = new ReaderFromXMLFile(filePath);
      string fileContains = readerFromXMLFile.ReadFromFile();
      StringContainsManipulator stringContainsManipulator = new StringContainsManipulator();
      string rootTag;
      Console.WriteLine(rootTag = stringContainsManipulator.GetRootTag(fileContains));
      string closingTag;
      Console.WriteLine(closingTag = stringContainsManipulator.GetClosingTag(fileContains));
      string mainContant = stringContainsManipulator.GetChildTags(fileContains, rootTag, closingTag);
      Console.ReadKey();
    }
  }
}