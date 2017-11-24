namespace DOM
{
  /// <summary>
  /// Entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string filePath = args[0];
      XMLReader XMLreader = new XMLReader(filePath);
      string xmlContent = XMLreader.ReadXML();
      XMLreader.GetContentInRoot();
    }
  }
}