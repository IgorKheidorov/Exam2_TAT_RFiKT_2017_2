using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace XMLToDomTask
{
    /// <summary>
    /// Xml format.
    /// </summary>
    public class XMLFormat
    {
        public const string FILE_NAME = "D:\\Git\\Exam2_TAT_RFiKT_2017_2\\Exam\\XMLToDomTask\\task.xml";
        public string FileData { get; set; }
        // Create an instance of StreamReader to read from an xml file.
        public void Read()
        {
            StringBuilder sb = new StringBuilder();
            // The using statement closes the StreamReader.
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    sb.Append(input);
                }
                sr.Close();
            }
            FileData = sb.ToString();
            Console.WriteLine(FileData);
        }
        /// <summary>
        /// Parses from xml to DOM.
        /// </summary>
        public bool TryParse()
        {
            bool isParsed = true;
            if (FileData == String.Empty)
            {
                isParsed = false;
            }
            return isParsed;
        }
        /// <summary>
        /// Method find first node.
        /// </summary>
        /// <returns></returns>
        public string FindFirstNode()
        {
            string rootNode = FindNextNode();
            Node node = new Node();
            node.Tag = rootNode;
             /// Expression should find child of rootNodes. (but it doesn't)
            string newMatch = Regex.Match(FileData, @"(?<=<" + rootNode + @">)(.*)(?=<" + rootNode + @"/>)")
                .ToString();
            return rootNode;
           // node.ChildNodes = new List<Node>{};
        }
        /// <summary>
        /// Find next node.
        /// </summary>
        /// <returns></returns>
        public string FindNextNode()
        {
            string rootNode = Regex.Match(FileData, @"(\<)(.*?)(\>)").ToString();
            rootNode = rootNode.Replace("<", String.Empty);
            rootNode = rootNode.Replace(">", String.Empty);
            return rootNode;
        }
        /// <summary>
        /// Split string by "<" and ">"
        /// </summary>
        public void ParseAllString()
        {
            string firstValue = FindNextNode();
            StringBuilder sb = new StringBuilder();
            string[] separ = new string[] { "<", ">" };
            string match = Regex.Match(FileData, @"(?<=<cars>)(.*)(?=<cars/>)")
                .ToString();
            string nextNode = Regex.Match(FileData, @"(\<)(.*?)(\>)").ToString();
            string[] splittedData = FileData.Split(separ, StringSplitOptions.RemoveEmptyEntries);
            foreach (string split in splittedData)
            {
                Console.WriteLine(split);
            }
            for (int i = 0; i < splittedData.Length; i++)
            {
                if (splittedData[i] == firstValue)
                {
                    continue;
                }
            }
        }
    }
}
