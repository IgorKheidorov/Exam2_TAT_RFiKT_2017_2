using System;

namespace TaskAboutLists
{
    /// <summary>
    /// Empty entry point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<string> list = new MyLinkedList<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
