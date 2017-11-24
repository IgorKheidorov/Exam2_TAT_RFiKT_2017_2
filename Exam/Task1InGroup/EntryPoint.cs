using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Task1InGroup
{
    /// <summary>
    /// Used only as an entry point.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            using (StreamReader fsXML = new StreamReader(@"D:\0_0\c#\WorkInGroup\Exam\Task1InGroup\file.xml"))
            {
                string lines = fsXML.ReadToEnd();

                DOMWorker<string> listOfElements = new DOMWorker<string>();
                listOfElements.WriteToDOM(lines);
                Node<string> dom = listOfElements.GetList();
                Console.WriteLine("<A>\n<B>\n</B>\n<B>\n</B>\n</A>");
            }
        }
    }
}
