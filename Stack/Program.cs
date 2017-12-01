

namespace StackImplementation
{
  /// <summary>
  /// The point where program starts.
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      MyStack<int> stack = new MyStack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Clear();
    }
  }
}
