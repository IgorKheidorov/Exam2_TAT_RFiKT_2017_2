using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsWithoutCollectionGeneric
{
  public class NodeDoublyLinkedList
  {
    public int Value { get; private set; }
    public NodeDoublyLinkedList Previous { get; set; }
    public NodeDoublyLinkedList Next { get; set; }

    /// <summary>
    /// This metod is used for initialization the node of DoubleLinkedList.
    /// </summary>
    /// <param name="value">
    /// The parameter which is a value of the node. 
    /// </param>
    public NodeDoublyLinkedList(int value)
    {
      Value = value;
    }

    public NodeDoublyLinkedList()
    { }
  }
}
