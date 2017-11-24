using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace XmlParserTask
{
    /// <summary>
    /// Class contains information about Xml file and methods 
    /// which can read xml file and find nodes of file.
    /// </summary>
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
        public void FindRootNode(string xmlText)
        {
            string pattern = @"<\w*>";
            string rootElement = Regex.Match(xmlText, pattern).ToString();
        }

        /// <summary>
        /// Find other nodes  of file between root node.
        /// </summary>
        /// <param name="xmlText">Xml string</param>
        /// <param name="rootElement"></param>
        public void FindNodes(string xmlText, string rootElement)
        {

        }

        /// <summary>
        /// Method 
        /// </summary>
        public void TryParse()

    }
}
