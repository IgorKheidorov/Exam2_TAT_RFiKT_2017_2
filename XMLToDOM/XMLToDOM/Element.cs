

namespace XMLToDOM
{
  /// <summary>
  /// For heir which we should get from cutted part.
  /// </summary>
  class Element
  {
    public string Teg { get; set; }
    public string Value { get; set; }

    /// <summary>
    /// Trivial constructor.
    /// </summary>
    /// <param name="teg"></param>
    /// <param name="value"></param>
    public Element(string teg, string value)
    {
      Teg = teg;
      Value = value;
    }

    public Element()
    { }
  }
}
