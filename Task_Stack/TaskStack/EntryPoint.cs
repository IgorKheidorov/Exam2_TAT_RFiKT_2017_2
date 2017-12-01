namespace TaskStack
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      NodeStack<int> stack = new NodeStack<int>();
      stack.Push(4);
      stack.Peek();
      stack.Pop();
      stack.Clear();
    }
  }
}