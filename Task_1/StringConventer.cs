using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class StringConventer
    {
        private char minus = '-';
        private char dot = '.';
        private char comma = ',';
        private int[] numbers = new int[] { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
        private StringAnalyzer stringAnalyzer;

        /// <summary>
        /// Makes an instance of StringConverter.
        /// </summary>
        public StringConventer()
        {
            stringAnalyzer = new StringAnalyzer();
        }

        /// <summary>
        /// Converts string to integer.
        /// </summary>
        /// <param name="str">Stringto convert</param>
        /// <returns>Integer from string.</returns>
        public int ConvertStringToInt(string str)
        {
            
            int number = 0;
            if (!stringAnalyzer.StringIsInteger(str))
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != dot)
                {
                    if (str[i] != comma && str[i] != minus)
                    {
                        number += GetInteger(str[i]) * (int)Math.Pow(10, str.Length - i);
                    }
                }
                if (!(number > -2147483647 && number < 2147483646) && i < str.Length)
                {
                    throw new ArgumentException();
                }
            }          
            if (str[0] == minus)
            {
                return -number;
            }
            return number;
        }

        /// <summary>
        /// Converts char to integer.
        /// </summary>
        /// <param name="symbol">Char to convert</param>
        /// <returns>Integer form char.</returns>
        public int GetInteger(char symbol)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((int)symbol == numbers[i])
                {
                    return i;
                }
            }
            throw new ArgumentException();
        }
    }
}
