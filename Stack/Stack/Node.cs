using System;

namespace Stack
{
  public class Node<T>
  {
    public T Element { get; set; }
    public Node<T> NextElement { get; set; }

    public Node(T element)
    {
      Element = element;
    }
  }
}
