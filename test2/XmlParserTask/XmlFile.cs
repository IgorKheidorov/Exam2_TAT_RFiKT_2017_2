using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace XmlParserTask
{
    public class XmlFile
    {
        private string path = @"D:\tat_task\XmlFile.xml";
        /// <summary>
        /// Method read information from XML file.
        /// </summary>
        /// <returns>String of information.</returns>
        public string ReadFile()
        {
            string xmlText;
            using (StreamReader streamReader = new StreamReader(path, Encoding.Default))
            {
                xmlText = streamReader.ReadToEnd();
            }
            return xmlText;
        }

        /// <summary>
        /// Add the root element of Xml file
        /// </summary>
        /// <params>Xml string<params>
        public void AddRootElement(string xmlText)
        {
            string pattern = @"<\w*>";
            string rootElement = Regex.Match(xmlText, pattern).ToString();
            rootElement = rootElement.Remove(rootElement.IndexOf('<'), 1);
            rootElement = rootElement.Remove(rootElement.IndexOf('>'), 1);
            Console.WriteLine(rootElement);
        }

        /// <summary>
        /// Add node element
        /// </summary>
        /// <params>Xml string<params>
        public void FindNode(string xmlText)
        {
            //string textBetweenTags = @"<.>"
        }

    }
}
