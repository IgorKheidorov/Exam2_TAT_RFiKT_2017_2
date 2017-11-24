using System;

namespace XmlToDom
{
  /*
   *  This program create struckt with data of xml file
   */
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        WorkWithXml workWithXml = new WorkWithXml();
        workWithXml.ReadXmlFile();
        String[] output = workWithXml.FindTag();
        foreach (var el in output)
        {
          Console.WriteLine(el);
        }
        Console.WriteLine();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}