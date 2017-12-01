using System;

namespace Test_3.Task_5
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        MyStack<string> stack = new MyStack<string>();
        stack.Push("123");
        stack.Push("abc");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
