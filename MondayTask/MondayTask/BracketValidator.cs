using System;
using System.Collections.Generic;

namespace MondayTask
{
    /// <summary>
    /// Class checks the valid arrangment of brackets.
    /// </summary>
    public class BracketValidator
    {
        Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            {'{','}'},
            {'(',')'},
            {'[',']'}
        };
        /// <summary>
        /// Method checks string for the valid bracket arrangment. 
        /// </summary>
        /// <param name="str">Checked string</param>
        /// <returns>True - arrangment is right.
        /// False - is not.</returns>
        public bool IsValidArrangment(string str)
        {
            bool isValid = false;
            char[] openBrackets = new char[] { '{', '(', '[' };
            char[] closeBrackets = new char[] { '}', ')', ']' };
            Stack<char> tempBrackets = new Stack<char>();
            for (int i = 0; i < openBrackets.Length; i++)
            {
                if (str.Length == 0)
                {
                    return true;
                }
                if (str.Contains(openBrackets[i].ToString()))
                {
                    tempBrackets.Push(openBrackets[i]);
                }
                if (str.Contains(closeBrackets[i].ToString())
                    && tempBrackets.Count == 0)
                {
                    return false;
                }
                /// If string contains 
                /// close bracket and stack is not empty 
                /// and breckets from stack and from string are equals than is true.
                if (str.Contains(closeBrackets[i].ToString())
                    && tempBrackets.Count != 0
                    && (AreBracketsEquals(tempBrackets.Pop(), closeBrackets[i])))
                {
                    isValid = true;
                }
            }
            if (tempBrackets.Count != 0)
            {
                isValid = false;
            }
            return isValid;
        }
        /// <summary>
        /// Checks two brackets for equality.
        /// </summary>
        /// <param name="ch">Bracket from stack.</param>
        /// <param name="actualChar">Bracket from the string</param>
        /// <returns>True - brackets are equal.
        /// False - are not.</returns>
        private bool AreBracketsEquals(char ch, char actualChar)
        {
            bool isEquals = false;
            foreach (KeyValuePair<char, char> keyValue in brackets)
            {
                if ((keyValue.Key == ch) && (keyValue.Value == actualChar))
                {
                    isEquals = true;
                }
            }
            return isEquals;
        }
    }
}
