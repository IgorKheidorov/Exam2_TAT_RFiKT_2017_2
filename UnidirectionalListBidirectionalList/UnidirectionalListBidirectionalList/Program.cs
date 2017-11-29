using System;
namespace UnidirectionalListBidirectionalList
{
  /// <summary>
  /// This program of two lists Unidirectional List and Bidirectional List
  /// </summary>
  class Program
  {
    /// <summary>
    /// This main is Empty
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        UnidirectionalList<string> unidirectional = new UnidirectionalList<string>();
        unidirectional.AddElement("First");
        unidirectional.AddElement("Third");
        unidirectional.AddElement("First");
        unidirectional.AddElement("Second");
        unidirectional.AddElement("First");
        unidirectional.AddElement("Third");
        unidirectional.AddElement("Final");
        for (int i = 0; i < unidirectional.Count; i++)
        {
          Console.WriteLine(unidirectional.GetData(i));
        }
      }
      catch
      {

      }
    }
  }
}
