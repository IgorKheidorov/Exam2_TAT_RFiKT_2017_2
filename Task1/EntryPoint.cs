using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number: ");
            IntegerValueChecker valueChecker = new IntegerValueChecker(Console.ReadLine());
            ToIntConverter converter = new ToIntConverter(valueChecker);
            try
            {
                Console.WriteLine(converter.ConvertToInt());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Number is not integer");
            }

        }
    }
}
