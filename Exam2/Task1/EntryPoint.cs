using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Used only as an entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                string inputLine = Console.ReadLine();

                ConverterToIntFromString converter = new ConverterToIntFromString();
                int number = converter.ConvertLineToInt(inputLine);
                Console.WriteLine(number);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
