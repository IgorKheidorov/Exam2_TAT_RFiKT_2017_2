using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_27_11_2017
{
    /// <summary>
    /// Checks the line for validity.
    /// </summary>
    public class CheckerCorrectLine
    {
        private string line;

        /// <summary>
        /// Standart constructor of class without parameters.
        /// </summary>
        public CheckerCorrectLine() { }

        /// <summary>
        /// Assign a value to an internal field "line".
        /// </summary>
        /// <param name="line">
        /// passing value
        /// </param>
        public CheckerCorrectLine(string line)
        {
            this.line = line;
        }

        /// <summary>
        /// Checks the line for validity by parethnesis
        /// </summary>
        /// <returns>
        /// Valid or not valid
        /// </returns>
        public bool CheckByBrakets()
        {
            bool isValid = true;
            
            CheckerCorrectLine checker = new CheckerCorrectLine();

            Stack<char> openingBraketsInLine = new Stack<char>() { };
            foreach (var elem in line)
            {
                if ("([{".IndexOf(elem) >= 0)
                {
                    openingBraketsInLine.Push(elem);
                }
                if (")]}".IndexOf(elem) >= 0 && openingBraketsInLine.Count == 0)
                {
                    isValid = false;
                    break;
                }
                else if (openingBraketsInLine.Count == 0)
                {
                    continue;
                }
                else if (")]}".IndexOf(elem) == "([{".IndexOf(openingBraketsInLine.Peek()))
                {
                    openingBraketsInLine.Pop();
                }
            }

            if (openingBraketsInLine.Count > 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}