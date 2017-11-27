using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAboutBrackets
{
    /// <summary>
    /// Entry point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringValidator validator = new StringValidator();
            Console.WriteLine("Enter an expression :");
            Console.WriteLine(validator.StringIsValid(Console.ReadLine()));
        }
    }
}
