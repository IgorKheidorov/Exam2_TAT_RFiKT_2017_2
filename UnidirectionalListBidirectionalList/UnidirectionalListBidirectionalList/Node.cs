namespace UnidirectionalListBidirectionalList
{
  /// <summary>
  /// This class of note of my unidirectional list
  /// </summary>
  /// <typeparam name="T">type of information of list</typeparam>
  public class Node<T>
  {
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    /// <summary>
    /// simple constuctor with param
    /// </summary>
    /// <param name="data"></param>
    public Node(T data)
    {
      Data = data;
    }
  }
}
