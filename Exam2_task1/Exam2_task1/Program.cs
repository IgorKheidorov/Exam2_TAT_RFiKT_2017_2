using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number to convert to integer.");
                string toInt = Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
