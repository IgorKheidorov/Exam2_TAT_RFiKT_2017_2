using System;

namespace LinkedLists
{
    /// <summary>
    /// Entry point to the program that realizes Linked lists ans double linked list.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinkedList ll = new LinkedList();
                ll.Add(3);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
