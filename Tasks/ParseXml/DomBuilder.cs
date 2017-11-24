using System;
using System.Collections.Generic;
using System.Text;

namespace ParseXml
{
  /// <summary>
  /// Class converts file in field File
  /// in DOM object with special methods
  /// </summary>
  public class DomBuilder
  {
    public string[] File { get; set; }
    private int CurrentLineIndex { get; set; }

    /// <summary>
    /// Init
    /// Read File from 0 (first) line
    /// </summary>
    /// <param name="inputFile"></param>
    public DomBuilder(string[] inputFile)
    {
      File = inputFile;
      CurrentLineIndex = 0;
    }

    /// <summary>
    /// Bild dom object like list with dom elements
    /// </summary>
    /// <returns></returns>
    public List<Element> BuildDomFromXml()
    {
      List<Element> domOject = new List<Element> {BuildElem()};
      return domOject;
    }

    /// <summary>
    /// Build dom Element
    ///  with nested inside elements
    /// </summary>
    /// <returns>Dom Element with name, value and child elems</returns>
    private Element BuildElem()
    {
      string currentLine = File[CurrentLineIndex];
      Element element = new Element();

      int closeTagIndex = currentLine.IndexOf('>');
      element.Tag = BindTagName(currentLine);

      string closingTag = element.Tag.Insert(1, "/");

      // If element locates only in one line
      if (currentLine.EndsWith(closingTag))
      {
        element.Value = currentLine.Substring(closeTagIndex + 1,
          currentLine.IndexOf(closingTag, StringComparison.Ordinal) - closeTagIndex - 1);
        CurrentLineIndex++;
        return element;
      }
      CurrentLineIndex++;

      // While did not put all the children in the parent element
      while (!BindTagName(File[CurrentLineIndex]).Equals(closingTag))
      {
        element.ChildElements.Add(BuildElem());
      }
      CurrentLineIndex++;

      return element;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="line"></param>
    /// <returns></returns>
    public string BindTagName(string line)
    {
      int openTagIndex = line.IndexOf('<');
      int closeTagIndex = line.IndexOf('>');
      return new StringBuilder("<")
        .Append(line.Substring(openTagIndex + 1, closeTagIndex - openTagIndex - 1))
        .Append('>').ToString();
    }
  }
}
