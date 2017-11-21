using System;

namespace Exam
{
    /// <summary>
    /// Class for parsing inputed string.
    /// </summary>
    public class IntegerParser
    {
        public const int ASCINORMALISATION = 48;
        public const char MINUS = '-';
        public const char ONE = '1';
        public const char NINE = '9';
        public const string COMMA = ",";
        public char[] InputedValue { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inpValue"> User inputed value</param>
        public IntegerParser(string inpValue)
        {
            if (inpValue.Contains(COMMA))
            {
                inpValue = inpValue.Remove(inpValue.IndexOf(COMMA));
                InputedValue = inpValue.ToCharArray();
            }
            else
            {
                InputedValue = inpValue.ToCharArray();
            }
        }
        /// <summary>
        /// Parses string to int
        /// </summary>
        /// <returns> Parsed string </returns>
        public int Parse()
        {
            bool isNegative = false;
            int resultValue = 0;
            int startPosition = 0;
            if (InputedValue[0] == MINUS && InputedValue.Length > 0)
            {
                isNegative = true;
                startPosition = 1;
            }
            for ( int i = startPosition; i < InputedValue.Length; i++ )
            {
                if (InputedValue[i] >= ONE && InputedValue[i] <= NINE)
                {
                    resultValue += ( InputedValue[i] - ASCINORMALISATION ) 
                        *  (int)Math.Pow(10, InputedValue.Length - i - 1);
                }
                else
                {
                    throw new FormatException();
                }
            }
            if ( resultValue > int.MaxValue)
            {
                throw new FormatException();
            }
            if ( isNegative )
            {
                resultValue = - resultValue;
            }
            return resultValue;
        }
    }
}
