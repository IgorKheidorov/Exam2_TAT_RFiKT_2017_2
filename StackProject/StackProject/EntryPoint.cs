using System;

namespace StackProject
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This is main method. 
    /// </summary>
    static void Main()
    {
      try
      {
        Stack<int> stack = new Stack<int>();
        Console.WriteLine(stack.IsEmpty());
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine(stack.IsEmpty());
        stack.Clear();
        Console.WriteLine(stack.IsEmpty());
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}