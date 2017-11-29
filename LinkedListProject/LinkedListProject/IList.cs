namespace LinkedListProject
{
  public interface IList<T>
  {
    void Add(T value);
    bool Remove(T value);
    void Clear();
    bool Contains(T value);
    void AddFirst(T value);
  }
}