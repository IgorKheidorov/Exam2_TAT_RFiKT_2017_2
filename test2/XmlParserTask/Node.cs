using System.Collections.Generic;

namespace XmlParserTask
{
    /// <summary>
    /// Class contains information about node of file.
    /// Value is the value between tags.
    /// Parameters is the parameters in node.
    /// List - list of childnodes this node.
    /// </summary>
    public class Node
    {
        public string Value { get; set; }
        public string Params { get; set; }
        List<Node> nodes = new List<Node>();
    }
}
