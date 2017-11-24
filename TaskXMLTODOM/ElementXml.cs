using System;
using System.Collections.Generic;

namespace XmlToDom
{
  /*
   * This class of element of tag.
   */
  class ElementXml
  {
    public String nameOfTag;
    public List<ElementXml> inserted = new List<ElementXml>();

    public ElementXml(String nameOfTag, List<ElementXml> inserted)
    {
      this.nameOfTag = nameOfTag;
      this.inserted = inserted;
    }

    public String getName()
    {
      return nameOfTag;
    }

    public List<ElementXml> getInserted()
    {
      return inserted;
    }

    public void setName(String nameOfTag)
    {
      this.nameOfTag = nameOfTag;
    }

    public void setInserted(List<ElementXml> inserted)
    {
      this.inserted = inserted;
    }
  }
}
