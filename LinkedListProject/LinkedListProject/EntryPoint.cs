using System;

namespace LinkedListProject
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  public class EntryPoint
  {
    /// <summary>
    /// This is empty main.
    /// </summary>
    static void Main()
    {
      try
      {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(5);
        linkedList.Add(3);
        linkedList.InitCurrentByHead();

      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}