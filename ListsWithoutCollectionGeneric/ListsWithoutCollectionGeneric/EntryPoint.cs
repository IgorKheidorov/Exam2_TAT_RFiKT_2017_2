using System;

namespace ListsWithoutCollectionGeneric
{
  /// <summary>
  /// The entry point of the programm.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      LinkedList linkedList = new LinkedList();
      linkedList.AddToStart(3);
      linkedList.AddToEnd(4);
      linkedList.AddToEnd(5);
    }
  }
}
