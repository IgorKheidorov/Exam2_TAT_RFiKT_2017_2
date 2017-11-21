using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Used only as a converter
    /// </summary>
    public class ConverterToIntFromString
    {
        /// <summary>
        /// Convert string to int without cheking a limit of int. 
        /// throw FormatException, if line isn't valid 
        /// </summary>
        /// <param name="line">
        /// sourse line
        /// </param>
        /// <returns>
        /// number
        /// </returns>
        public int ConvertLineToInt(string line)
        {
            int number = 0;

            var degree = new ConverterToIntFromString().MaxDegree(line);

            for (int i = 0; i < line.Length; i++)
            {

                if (line[i] >= '0' && line[i] <= '9')
                {
                    var pow = Math.Pow(10, degree--);
                    number += (line[i] - 48) * (int)pow;
                }
                else if (line[i] == '.')
                {
                    break;
                }
                else if (line[i] == ',')
                {
                    continue;
                }
                else
                {
                    throw new FormatException();
                }
            }

            return number;
        }

        private int MaxDegree(string line)
        {
            int i = 0;
            int degree = 0;

            while (line[i] != '.' && i < line.Length - 1)
            {
                if (line[i] >= '0' && line[i] <= '9')
                {
                    degree++;
                }

                i++;
            }

            return degree;
        }
    }
}
