using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConverterFromTxtToXML
{
  /// <summary>
  /// Parses XML.
  /// </summary>
  public class XMLParser
  {
    private FileStream fileStream;
       
    private string Read()
    {
      StringBuilder line = new StringBuilder();
      char symbol = new char();
      do
      {
        symbol = (char)fileStream.ReadByte();
        if (symbol == '>')
        {
          line.Append(symbol);
          break;
        }
        line.Append(symbol);
      }
      while (true);    
      return line.ToString();
    }

    /// <summary>
    /// Creates List of elements of XML.
    /// </summary>
    /// <param name="path">Path of XML.</param>
    /// <returns>List of elements of XML.</returns>
    public List<Element> ParseXML(string path)
    {
      List<Element> elements = new List<Element>();       
      string currentString = string.Empty;
      using (fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
      {
        while (fileStream.Position < fileStream.Length)
        {
          currentString = this.Read();
          if (IsTag(currentString))
          {
            elements.Add(BuildElement(currentString));
          }
        }
      }
      return elements;
    }

    private Element BuildElement(string currentString)
    {
      Element element = new Element();
      element.name = EjectLetters(currentString);
      string value = string.Empty;
      do
      {
        currentString = this.Read();
        if (EjectLetters(currentString) != element.name && IsTag(currentString))
        {
          element.subElements.Add(BuildElement(currentString));
        }
        else if (IsValue(currentString))
        {
          element.value = EjectLetters(currentString);
        }
      }
      while (EjectLetters(currentString) != element.name);
      return element;
    }
    
    /// <summary>
    /// Ejects letters from string.
    /// </summary>
    /// <param name="str">String.</param>
    /// <returns>Returns only letters from string.</returns>
    public string EjectLetters(string str)
    {
      throw new NotImplementedException();
    }

    private bool IsTag(string str)
    {
      return str.Contains("<") && !str.Contains("?") && !str.Contains("/");
    }

    private bool IsValue(string str)
    {
      return !str.Contains("<") && !str.Contains("?") && !str.Contains("/");
    }
  }
}
