using System;


namespace Task_1
{
    /// <summary>
    /// Analyze string.
    /// </summary>
    public class StringAnalyzer
    {
        private char minus = '-';
        private char dot = '.';
        private char comma = ',';
        

        /// <summary>
        /// Analyzes string.
        /// </summary>
        /// <param name="str">String to analyze</param>
        /// <returns>True if string is integer;otherwise false.</returns>
        public bool StringIsInteger(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {                
                if (!(str[i] > 47 && str[i] < 58))
                {
                    return false;
                }
                if (str[i] == dot)
                {
                    if (str[0] == minus && i > 11)
                    {
                        return false;
                    }
                    else if (str[0] != minus && i > 10)
                    {
                        return false;
                    }
                }         
            }          
            return true;
        }
    }
}
