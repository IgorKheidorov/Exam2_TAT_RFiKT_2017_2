namespace XMLToDOM
{
  /// <summary>
  /// For calling all methods.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// The entry point of the programm.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      SearcherTags read = new SearcherTags();
      read.GetTegs(read.GetStringFromTXT());
    }
  }
}
