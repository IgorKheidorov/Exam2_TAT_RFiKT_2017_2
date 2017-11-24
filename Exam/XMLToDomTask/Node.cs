using System;
using System.Collections.Generic;

namespace XMLToDomTask
{
    /// <summary>
    /// Class Node that has tag and referense to his child.
    /// </summary>
    class Node
    {
        public string Tag { get; set; }
        public string Value { get; set; }
        public List<Node> ChildNodes = new List<Node>();
    }
}
