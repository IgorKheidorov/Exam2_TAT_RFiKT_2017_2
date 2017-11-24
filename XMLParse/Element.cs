using System.Collections.Generic;

namespace ConverterFromTxtToXML
{
  /// <summary>
  /// Represents element of XML.
  /// </summary>
  class Element
  {
    public string name { get; set; }
    public string value { get; set; }
    public List<Element> subElements { get;  set; }      
  }
}
