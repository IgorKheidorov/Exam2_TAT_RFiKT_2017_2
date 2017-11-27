using System;

namespace Task2_27_11_2017
{
    /// <summary>
    /// Used only as an entry point.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter line:");
                string line = Console.ReadLine();

                CheckerCorrectLine checker = new CheckerCorrectLine(line);
                if (checker.CheckByBrakets())
                {
                    Console.WriteLine("Line is valid.");
                }
                else
                {
                    Console.WriteLine("Line isn't valid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
