﻿using System;

namespace List_Wednesday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            for (int i = 0; i < list.Count() ; i++)
            {
                Console.WriteLine(list.GetCurrentValue());
            }
        }
    }
}
