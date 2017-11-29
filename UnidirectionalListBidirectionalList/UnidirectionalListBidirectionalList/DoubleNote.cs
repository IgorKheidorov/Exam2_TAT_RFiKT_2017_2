namespace UnidirectionalListBidirectionalList
{
  /// <summary>
  /// This class of double note of my Biidirectional list
  /// </summary>
  /// <typeparam name="T">type of information of list</typeparam>
  public class DoublyNode<T>
  {
    public T Data { get; set; }
    public DoublyNode<T> Previous { get; set; }
    public DoublyNode<T> Next { get; set; }
    public DoublyNode(T data)
    {
      Data = data;
    }
    
  }
}
