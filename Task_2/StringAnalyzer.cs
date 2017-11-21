using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// Analyzes string.
    /// </summary>
    class StringAnalyzer
    {
        private string stringToAnalyze;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="stringToAnalyze">String to analyze.</param>
        public StringAnalyzer(string stringToAnalyze)
        {
            this.stringToAnalyze = stringToAnalyze;
        }

        /// <summary>
        /// Check if string can be creating from other.
        /// </summary>
        /// <param name="otherString">Other string</param>
        /// <returns>True if string can be creating from other; otherwise false.</returns>
        public bool StringCanBeCreatingFrom(string otherString)
        {
            foreach (char symbol in otherString)
            {
                if (!stringToAnalyze.Contains(symbol))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
