using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1InGroup
{
    /// <summary>
    /// Realise nodes
    /// </summary>
    public struct Node<T>
    {
        public T parent;
        public List<Node<T>> childs;

        public Node(T parent)
        {
            childs = new List<Node<T>> { };
            this.parent = parent;
        }
    }
}
