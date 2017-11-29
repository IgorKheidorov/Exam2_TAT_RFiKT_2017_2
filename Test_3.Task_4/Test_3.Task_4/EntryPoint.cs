using System;

namespace Test_3.Task_4
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        SinglyLinkedList list = new SinglyLinkedList();
        Node node = new Node(2);
        node.Next = new Node(3);
        list.AddBack(1);
        list.AddBack(2);
        list.AddBack(3);
        list.AssignFirstToCurrent();
        list.GetNext();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
