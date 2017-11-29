using System;

namespace Task4_29_11_17
{
    /// <summary>
    /// Used only as an entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                DoubleLinkedList<int> list = new DoubleLinkedList<int>();
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);
                list.Add(6);
                list.Add(7);
                list.Add(8);

                var element = list.GetTail();
                while (element != null)
                {
                    list.Display(element);
                    element = list.GetPrevious(element);
                }

                Console.WriteLine();

                element = list.GetHead();
                while (element != null)
                {
                    list.Display(element);
                    element = list.GetNext(element);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
