using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StringConventer conventer = new StringConventer();
            int number = 0;
            Console.WriteLine("Enter string :");
            try
            {
                number = conventer.ConvertStringToInt(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("It isn't integer.");
            }
            Console.WriteLine(number);
            
        }
    }
}
