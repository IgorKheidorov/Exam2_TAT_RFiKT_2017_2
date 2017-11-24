using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1InGroup
{
    /// <summary>
    /// Work as DOM
    /// </summary>
    public class DOMWorker<T>
    {
        private Node<T> listOfNodes = new Node<T>();
        
        /// <summary>
        /// write to DOM
        /// </summary>
        /// <param name="line">
        /// sourse line
        /// </param>
        public void WriteToDOM (string lines)
        {
            string[] line = lines.Split('\n');
            DOMWorker<string> worker = new DOMWorker<string>();

            Node<string> parent = new Node<string>();

            parent.parent = worker.GiveName(worker.FindParentTag(line));

            List<Node<string>> child = new List<Node<string>>();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].IndexOf('/') < 0 && line[i].IndexOf('<') >= 0)
                {
                    child.Add(new Node<string>(worker.GiveName(line[i])));
                }
            }

            parent.childs = child;
            
        }
        private string FindParentTag(string[] lines)
        {
            int CountOfTag = 1;
            int positionOfTag = 0;
            DOMWorker<string> worker = new DOMWorker<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (CountOfTag > 2 || (i == lines.Length - 1 && CountOfTag <= 1))
                {
                    i = positionOfTag++;
                    CountOfTag = 0;
                    continue;
                }

                if (worker.FindClosingTagPosition(positionOfTag, lines) != 0)
                {
                    if (lines[positionOfTag] == lines[i] && i != positionOfTag)
                    {
                        CountOfTag++;
                    }
                    else if (i == lines.Length - 1)
                    {
                        break;
                    }
                }
                else
                { 
                    i = positionOfTag++;
                    CountOfTag = 0;
                    continue;
                }
            }

            return lines[positionOfTag - 1];
        }

        private string GiveName(string line)
        {
            string name = line.Trim('>');
            name = name.Trim('<');
            return name;
        }

        private int FindClosingTagPosition(int positionOfTag, string[] lines)
        {
            int positionOfSlash = lines[positionOfTag].IndexOf('<') + 1;
            var closingTag = lines[positionOfTag].Insert(positionOfSlash, "/");

            int position = 0;
            for (var i = positionOfTag; i < lines.Length; i++)
            {
                if (lines[i] == closingTag)
                {
                    position = i;
                    break;
                }
            }

            return position;
        }
        
        public Node<T> GetList()
        {
            return listOfNodes;
        }
    }
}