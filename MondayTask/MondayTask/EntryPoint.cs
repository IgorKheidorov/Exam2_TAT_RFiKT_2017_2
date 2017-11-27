using System;
using System.Collections.Generic;

namespace MondayTask
{
    /// <summary>
    /// Entry point to the program.
    /// Program defines the right arrangment of brackets.
    /// </summary>
    class EntryPoint
    {
        public const string INPUT_PROMPT = "Input the string: ";
        /// <summary>
        /// Main method of the programm.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(INPUT_PROMPT);
                string str = Console.ReadLine();
                Console.WriteLine(new BracketValidator().IsValidArrangment(str));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
