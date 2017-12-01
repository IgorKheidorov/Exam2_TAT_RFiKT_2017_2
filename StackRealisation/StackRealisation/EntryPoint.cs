using System;
using System.Collections.Generic;

namespace StackRealisation
{
    /// <summary>
    /// Enrty point to the program that realizes Stack.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                MyStack<int> s = new MyStack<int>();
                s.Push(3);
                Console.WriteLine(s.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
