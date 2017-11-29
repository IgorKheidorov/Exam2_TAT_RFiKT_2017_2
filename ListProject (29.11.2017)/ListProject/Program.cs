using System;

namespace ListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Remove(3);
            list.Add(3);
            while ( a != null)
            {
                Console.WriteLine(list.GetNext());
            }

        }
    }
}
