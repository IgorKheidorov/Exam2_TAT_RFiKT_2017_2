using System;

namespace MyStack
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// Calls all methods
    /// </summary>
    /// <param name="args">arguments from console</param>
    static void Main(string[] args)
    {
      try
      {
        StackOnList<int> myStack = new StackOnList<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        myStack.Pop();
        myStack.Peek();
      }
      catch(Exception ex)
      {
        Console.Write(ex.Message);
      }
    }
  }
}
