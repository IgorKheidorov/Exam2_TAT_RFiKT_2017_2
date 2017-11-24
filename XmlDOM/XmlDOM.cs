using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    class XmlDOM
    {
        ChildStruct parent;
        string[] manageSymbols = { "<", ">", "</" };
        const string declarativeString = @"<?xml version=""1.0"" encoding=""UTF-8""?>";
        string[] separators = { "/r/n", " " };
 
        public XmlDOM()
        {
            parent = new ChildStruct();
        }
        /// <summary>
        /// method delete spaces and new line symbol from inside data
        /// </summary>
        /// <param name="data">all information from xml file</param>
        /// <returns></returns>
        public void ParseDocument(string data)
        {
            data.Replace(" ", string.Empty);
            data.Replace("/r/n", string.Empty);
            if ( data.StartsWith(declarativeString))
            {
                data = data.Replace(declarativeString, string.Empty);
            }            
            parent = GetChilds(data);
        }


        /// <summary>
        /// method run by recursion and add childs elements in parent's list 
        /// and set tag name
        /// </summary>
        /// <param name="insideData">data for element, which serves as a supplier
        /// childs elements
        /// </param>
        /// <returns>struct with child element</returns>
        private ChildStruct GetChilds(string insideData)
        {
            ChildStruct child = new ChildStruct();
            string closedTag;
            string subElement;
            string remainingInformation = insideData;
            int openTagStartIndex, openTagEndIndex, closeTagStartIndex, closeTagEndIndex;
            /*
             * loop get subelement for recursion method and cut remaining information
             */
            while (remainingInformation.StartsWith(manageSymbols[0]))
            {              
                openTagStartIndex = remainingInformation.IndexOf(manageSymbols[1]);
                openTagEndIndex = remainingInformation.IndexOf(manageSymbols[1]);
                closedTag = manageSymbols[2] + child.Name + manageSymbols[1];
                closeTagStartIndex = remainingInformation.IndexOf(closedTag);
                closeTagEndIndex = closeTagStartIndex + closedTag.Length - 1;
                child.Name = insideData.Substring(1, openTagEndIndex - 1);
                remainingInformation = remainingInformation.Substring(closeTagEndIndex + 1);
                subElement = remainingInformation.Substring(openTagStartIndex + 1, closeTagStartIndex - 1);
                child.childs.Add(GetChilds(remainingInformation));               
            }
            return child;
        }

    }
}
